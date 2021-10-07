using System;

namespace BinaryTreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program");
            BinarySearchTree<int> binaryTree = new BinarySearchTree<int>(56);

            binaryTree.Add(30);
            binaryTree.Add(70);
            binaryTree.Display();

            binaryTree.TreeSize();

        /*    binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);*/

        }
    }
}
