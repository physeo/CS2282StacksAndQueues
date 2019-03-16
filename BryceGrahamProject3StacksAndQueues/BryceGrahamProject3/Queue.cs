/********************************************
 Queue Class
 Bryce Graham
 CS 2282
 Dr. Beard
 2/12/15
 Purpose: 
*********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryceGrahamProject3
{
    class Queue<T> : Dequeue<T>
    {
        public Queue()
            :base()
        {

        }

        // Adds an item to the top of the stack
        public void push(T item)
        {
            base.pushBack(item);
        }

        // Removes the top item from the stack
        public T pop()
        {
            if (!base.isEmpty())
                return base.popFront();
            else throw new Exception("Stack is empty");
        }

        // Gives the top item in the stack
        public T peek()
        {
            return base.peekFront();
        }
    }
}
