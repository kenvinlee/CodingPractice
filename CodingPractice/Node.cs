﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    public class Node
    {
        private int nodeValue;
        private Node parent;
        private Node child;

        public Node()
        {
            nodeValue = 0;
        }

        public Node(int value)
        {
            this.nodeValue = value;
        }

        public Node(int value, Node child)
        {
            this.nodeValue = value;
            this.child = child;
        }

        public void setValue(int value)
        {
            nodeValue = value;
        }

        public int getValue()
        {
            return nodeValue;
        }

        public void setParent(Node parent)
        {
            this.parent = parent;
        }

        public Node getParent()
        {
            return parent;
        }

        public void setChild(Node child)
        {
            this.child = child;
        }

        public Node getChild()
        {
            return child;
        }
    }
}