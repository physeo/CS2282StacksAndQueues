/********************************************
 Stack Class
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
    class Stack<T> : Dequeue<T>
    {
        public Stack()
            :base()
        {
           
        }

        // Adds an item to the top of the stack
        public void push(T item)
        {
            base.pushFront(item);
        }

        // Removes the top item from the stack
        public T pop()
        {
            return base.popFront();
        }

        // Gives the top item in the stack
        public T peek()
        {
            return base.peekFront();
        }
    }
}
