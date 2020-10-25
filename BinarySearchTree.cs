// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearchTree.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace BST_DS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// BST Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class BinarySearchTree<T> where T:IComparable
    {
        /// <summary>
        /// The root data
        /// </summary>
        public T rootData;

        /// <summary>
        /// The left branch tree
        /// </summary>
        public BinarySearchTree<T> left;

        /// <summary>
        /// The right branch tree
        /// </summary>
        public BinarySearchTree<T> right;

        /// <summary>
        /// Initializes a new instance of the <see cref="BinarySearchTree{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public BinarySearchTree(T data)
        {
            this.rootData = data;
            this.left = null;
            this.right = null;
        }

        /// <summary>
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Insert(T data)
        {
            if (data.CompareTo(rootData) <= 0)
            {
                if(this.left == null)
                {
                    this.left = new BinarySearchTree<T>(data);
                }
                else
                {
                    this.left.Insert(data);
                }
            }
            else
            {
                if(this.right == null)
                {
                    this.right = new BinarySearchTree<T>(data);
                }
                else
                {
                    this.right.Insert(data);
                }
            }
        }

        /// <summary>
        /// In order traversal of bst.
        /// </summary>
        public void InOrderTraversal()
        {
            if (this.left != null)
            {
                this.left.InOrderTraversal();
            }
            Console.Write(this.rootData + " ");
            if (this.right != null)
            {
                this.right.InOrderTraversal();
            }
        }
    }
}
