using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeExample
{
    class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }

        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.RightTree = null;
            this.LeftTree = null;
        }

        int leftCount = 0, rightCount = 0;
        bool result = false;
        
        public void Add(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                Console.WriteLine((currentNodeValue.CompareTo(item)));
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySearchTree<T>(item);
                else
                    this.LeftTree.Add(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(item);
                else
                    this.RightTree.Add(item);
            }

        }

        public void Display()
        {
            if(this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if(this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        public bool Search(T searchData, BinarySearchTree<T> node)
        {
            if(node == null)
            {
                return false;
            }
            if(node.NodeData.Equals(searchData))
            {
                return true;
            }
            else if(searchData.CompareTo(node.NodeData) < 0)
            {
                Search(searchData, node.LeftTree);
            }
            else if(searchData.CompareTo(node.NodeData) > 0)
            {
                Search(searchData, node.RightTree);
            }
            return result;

        }

        //get the size of the tree
        public void TreeSize()
        {
            Console.WriteLine("The Size of the Binary Search Tree is : " + (this.leftCount + this.rightCount + 1));
        }
    }
}
