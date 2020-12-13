using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeHeight
{
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public Node()
        {
            Left = null;
            Right = null;
        }

        public static Node createNode(int number)
        {
            return new Node(number);
        }
    }
}
