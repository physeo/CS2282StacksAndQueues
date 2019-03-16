/********************************************
 Form1
 Bryce Graham
 CS 2282
 Dr. Beard
 2/13/15
 Purpose: A form that allows user interface
 between the stack and queue classes and
 handles expression evaluation and conversion
 to postfix notation
*********************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BryceGrahamProject3
{
    public partial class stackTester : Form
    {
        Stack<String> myStack = new Stack<String>();
        Queue<String> myQueue = new Queue<String>();
 
        public stackTester()
        {
            InitializeComponent();
        }

        // Pushes input value onto stack
        private void stackPushButton_Click(object sender, EventArgs e)
        {
            myStack.push(stackTextBox.Text.Trim());
            displayList.Items.Add(stackTextBox.Text.Trim());
            stackTextBox.Clear();
        }

        // Pops top value from stack
        private void stackPopButton_Click(object sender, EventArgs e)
        {
            var popItem = myStack.pop();
            displayBox.Text = popItem;
            displayList.Items.Remove(popItem);
        }

        // Peeks at top of stack
        private void stackPeekButton_Click(object sender, EventArgs e)
        {
            displayBox.Text = myStack.peek();
        }

        // Pushes value into queue
        private void queuePushButton_Click(object sender, EventArgs e)
        {
            myQueue.push(queueTextBox.Text.Trim());
            displayList.Items.Add(queueTextBox.Text.Trim());
            queueTextBox.Clear();
        }

        // Pops value from top of queue
        private void queuePopButton_Click(object sender, EventArgs e)
        {
            var popItem = myQueue.pop();
            displayBox.Text = popItem;
            displayList.Items.Remove(popItem);
        }

        // Peeks at value at top of queue
        private void queuePeekButton_Click(object sender, EventArgs e)
        {
            displayBox.Text = myQueue.peek();
        }

        // Evaluates a postfix expression
        private void evaluateButton_Click(object sender, EventArgs e)
        {
            displayBox.Text = "Answer: " + evaluatePostfixExpr(expressionText.Text.Trim());
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            displayBox.Text = convertToPostfix(expressionText.Text.Trim());
        }

        // Calculates the value of a postfix expression
        public int evaluatePostfixExpr(string expr)
        {
            Stack<char> operatorStack = new Stack<char>();
            Stack<int> operandStack = new Stack<int>();
            
          for(int i = 0; i < expr.Length; i++)
          {
              if (char.IsDigit(expr[i]))
                  operandStack.push(int.Parse(expr[i].ToString()));
              else if (expr[i] == '+' || expr[i] == '-' ||
                  expr[i] == '*' || expr[i] == '/')
              {
                  operatorStack.push(expr[i]);
                  doOp(operatorStack, operandStack);
              }                
          }
          int finalValue = operandStack.pop();
          return finalValue;
        }

        // Performs mathematic operations on a stack
        private void doOp(Stack<char> operatorStack, Stack<int> operandStack)
        {
            char op = operatorStack.pop();
            int op1 = operandStack.pop();
            int op2 = operandStack.pop();
            if (op == '+')
                operandStack.push(op2 + op1);
            else if (op == '-')
                operandStack.push(op2 - op1);
            else if (op == '*')
                operandStack.push(op2 * op1);
            else if (op == '/')
                operandStack.push(op2 / op1);
        }

        // Runs through an algorithm to convert infix notation to postfix notation
        private string convertToPostfix(string strToConvert)
        {
            string postfixStr = String.Empty;
            Stack<char> opStack = new Stack<char>();
            char temp;

            for (int i = 0; i < strToConvert.Length; i++)
            {
                if (strToConvert[i] == ' ')
                    i++;
                else if (char.IsDigit(strToConvert[i]))
                    postfixStr += strToConvert[i];
                else if (opStack.isEmpty())
                    opStack.push(strToConvert[i]);
                else if (strToConvert[i] == '(')
                    opStack.push(strToConvert[i]);
                else if (strToConvert[i] == ')')
                {
                    temp = opStack.pop();
                    while (temp != '(')
                    {
                        postfixStr += temp;
                        temp = opStack.pop();
                    }
                }

                else
                {
                    while (!opStack.isEmpty() &&
                        comparePrecedence(opStack.peek(), strToConvert[i]))
                    {
                        postfixStr += opStack.pop();
                    }
                    opStack.push(strToConvert[i]);
                }
            }

            for (int j = 0; j < opStack.count(); j++)
                postfixStr += opStack.pop();

            return postfixStr;
        }
            

        // Determines if the firstOp has higher precedence than secondOp
        private bool comparePrecedence(char stackTop, char nextOp)
        {
            if ((nextOp == '+' || nextOp == '-') &&
                (stackTop == '*' || stackTop == '/'))
                return true;
            else if ((nextOp == '+' || nextOp == '-') &&
                (stackTop == '+' || stackTop == '-'))
                return true;
            else if ((nextOp == '*' || nextOp == '/') &&
            (stackTop == '*' || stackTop == '/'))
                return true;
            else return false;
        }

    }
}
