using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    class Stack
    {
        // basic stack class with some extra functionality done using doubly linked list
        // could be done using singly linked list to be slightly more efficient

        private Node top;
        private int size = 0;

        public Stack()
        {
            top = null;
        }

        public void push(Node data)
        {
            if (top == null)
            {
                top = data;
            }
            else
            {
                data.setChild(top);
                top.setParent(data);
                top = data;
            }

            size++;
        }

        public Node pop()
        {
            Node temp = top;

            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            else if (top.getChild() == null)
            {
                // there's only one Node in the stack
                top = null;
                size--;
                return temp;
            }
            else
            {
                top = temp.getChild();
                top.setParent(null);
                size--;
                return temp;
            }
            
        }

        // shows you the top node without actually popping it off
        public Node peek()
        {
            // top is null if stack is empty
            return top;
        }
    }
}
