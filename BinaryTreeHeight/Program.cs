using System;

namespace BinaryTreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Head = Node.createNode(70);

            Node Node1 = Node.createNode(50);
            Node Node2 = Node.createNode(90);
            Node Node3 = Node.createNode(55);

            // Level 1
            Head.Left = Node1;
            Head.Right = Node2;

            // Level 2
            Node1.Left = Node.createNode(35);
            Node1.Right = Node.createNode(25);
            Node2.Left = Node.createNode(75);
            Node1.Right = Node3;

            // Level 3
            Node3.Left = Node.createNode(10);
            Node3.Right = Node.createNode(30);

            Console.WriteLine($"Height of a Binary Tree is :{Height(Head)}");
        }

        public static int Height(Node root)
        {
            if (null == root)
                return 0;
            int hLeftSub = Height(root.Left);
            int hRightSub = Height(root.Right);
            return Math.Max(hLeftSub, hRightSub) + 1;
        }
    }
}
