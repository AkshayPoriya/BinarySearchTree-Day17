// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearchTree.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya "/>
// --------------------------------------------------------------------------------------------------------------------
namespace BST_DS
{
    using System;

    /// <summary>
    /// Contains Main Function
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.InOrderTraversal();
        }
    }
}
