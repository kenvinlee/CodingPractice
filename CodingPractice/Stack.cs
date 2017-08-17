using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    class Stack
    {
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

        public Node peek()
        {
            return top;
        }
    }
}
