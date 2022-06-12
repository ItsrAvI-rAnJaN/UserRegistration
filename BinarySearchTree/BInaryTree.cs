using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    // Create Genric Class to Compare when we Insert New NOde
    internal class BinaryTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }

        //For Left Sub-Tree
        public BinaryTree<T> LeftTree { get; set; }

        //For Right Sub-Tree
        public BinaryTree<T> RightTree { get; set; }

        public BinaryTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        //Declaring Static Variables for left & Right Node
        //Declaring Static Variables Because it will be Assigned Only once not to be Changed
        //This is  helpfull in recursion since we have recursion in displaying method
        //If Recursion Starts Value of Variables Changed Every Time So We Decelaring Static
        //The value we will get in output will be the value before the first recursion starts
        public static int LeftCount = 0;
        public static int RightCount = 0;

        //Insertion logic
        public void Insert(T Item)
        {
            T CurrentNodeValue = NodeData;

            //Define Logic If Else Current Node Value is Greater or not
            if ((CurrentNodeValue.CompareTo(Item)) > 0)
            {
                // Define Logic Left Tree is null or not when Null then Add & if not Null Then Recursive Method call to add.
                if (LeftTree == null)
                {
                      LeftTree = new BinaryTree<T>(Item);
                }
                
                else
                {
                    LeftTree.Insert(Item);
                }
            }

            else
            {
                //Define Logic Right Tree is null or not when Null then Add & if not Null Then Recursive Method call to add.
                if (RightTree == null)
                {
                    RightTree = new BinaryTree<T>(Item);
                }
                else
                {
                    RightTree.Insert(Item);
                }
            }
        }

        //For displaying binary search tree
        public void Display()
        {
            // Define Logic When Left Tree is not Null then increment the node count of left subtree 
            if (LeftTree != null)
            {
                LeftCount++;
                LeftTree.Display(); // To display Left Sub-Tree
            }

           // Printing Value Present in Node
            Console.Write(NodeData.ToString() + " ");

            //Define Logic When Right Tree is not null or Value Present then increment the node count of right subtree
            if (RightTree != null)
            {
                RightCount++;
                RightTree.Display(); // To Display Right Sub-Tree
            }
        }

    }
}
