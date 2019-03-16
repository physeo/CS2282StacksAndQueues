/********************************************
 Dequeue Class
 Bryce Graham
 CS 2282
 Dr. Beard
 2/12/15
 Purpose: A generic Dequeue class used as a
 a base for stack and queue classes
*********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BryceGrahamProject3
{
    abstract class Dequeue<T>
    {
        private List<T> list;

        protected Dequeue()
        {
            list = new List<T>();
        }

        protected List<T> List
        {
            get { return list; }
        }

        public bool isEmpty()
        {
            if (list.Count == 0)
                return true;
            else return false;
        }

        // Adds a new value to the end of a list
        protected void pushFront(T item)
        {
            list.Add(item);
        }

        // Adds a new value to the beginning of a list
        protected void pushBack(T item)
        {
            list.Insert(0, item);
        }

        // Removes the value at the end of a list
        protected T popFront()
        {
            if(!isEmpty())
            {
                T popItem = list[list.Count() - 1];
                list.RemoveAt(list.Count() - 1);
                return popItem;
            }
            else
            {
                throw new System.ArgumentException("No item available");
            }
        }

        // Removes the value from the beginning of a list
        protected T popBack()
        {
            if (!isEmpty())
            {
                T popItem = list[0];
                list.RemoveAt(0);
                return popItem;
            }
            else
            {
                throw new System.ArgumentException("No item available");
            }
        }

        // Gives the value from the end of a list
        protected T peekFront()
        {
            if (!isEmpty())
                return list[list.Count() - 1];
            throw new System.ArgumentException("No item available");

        }

        // Gives the value from the beginning of a list
        protected T peekBack()
        {
            if (!isEmpty())
                return list[0];
            throw new System.ArgumentException("No item available");
        }

        // Gives the number of items in the list
        public int count()
        {
            return list.Count();
        }
    }
}
