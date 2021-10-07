using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeExample
{
    class BinarySearchTree<T> where T : IComparable<T>
    {
        public T Root { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }

        public BinarySearchTree(T nodeData)
        {
            this.Root = nodeData;
            this.RightTree = null;
            this.LeftTree = null;
        }

        int leftCount = 0, rightCount = 0;
        
        public void Add(T item)
        {
            T currentNodeValue = this.Root;
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
            Console.WriteLine(this.Root.ToString());
            if(this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
    }
}
