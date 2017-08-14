using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    // doubly linked list
    class LinkedList
    {
        private Node head;
        private Node tail;

        private int length;

        public LinkedList()
        {
            length = 0;
        }

        public void insertEmpty(Node item)
        {
            // if the list is empty
            head = item;

            length++;
        }

        public void insertHead(Node item)
        {
            // insert item as head
            
            head.getChild().setParent(item);
            head.setChild(item);
            head = item;

            length++;           
        }

        public void insertTail(Node item)
        {
            // insert item as tail
            tail.getChild().setChild(item);
            item.setParent(tail);
            tail = item;

            length++;
        }

        public void insertBefore(Node item, Node index)
        {
            // insert item before index
            if (index.getParent() != null)
            {
                item.setParent(index.getParent());
                item.getParent().setChild(item);

                item.setChild(index);
                index.setParent(item);
            } 
            else
            {
                // if index' parent is null, you're inserting a new head of the list
                insertHead(item);
            }

            length++;
        }

        public void insertAfter(Node item, Node index)
        {
            // insert item before index
            if (index.getChild() != null)
            {
                item.setChild(index.getChild());
                item.getChild().setParent(item);

                item.setParent(index);
                index.setChild(item);
            }
            else
            {
                // if index' child is null, you're inserting a new tail of the list
                insertHead(item);
            }

            length++;
        }

        public void delete(Node item)
        {

            // if the user is cheeky and tries to delete nothing
            if (item == null)
            {
                Console.WriteLine("Item does not exist in list");
            }
            
            // reassign pointers that link the next element
            if (item.getChild() == null)
            {
                tail = item.getParent();
            } 
            else if (item.getParent() != null)
            {
                item.getParent().setChild(item.getChild());
            }

            // reassign pointers that link the previous element
            if (item.getParent() == null)
            {
                head = item.getChild();
            }
            else if (item.getChild() != null)
            {
                item.getChild().setParent(item.getParent());
            }
        }

        public int getLength()
        {
            return length;
        }

    }
}
