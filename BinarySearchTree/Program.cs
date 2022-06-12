using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t*******WELCOME TO BINARY SEARCH TREE PROGRAM*******");

            Console.WriteLine("\nQ1. Create Binary Search Tree & Adding 56, 30 & 70");
            Console.WriteLine("Enter O to Exit");
            Console.Write("Enter Question Number You Want to Execute : ");
            int Choice =Convert.ToInt32(Console.ReadLine());

            // Define Stitch Case Logic to Execute Question as User Want to Execute
            switch (Choice)
            {
                case 1:
                    BinaryTree<int> objTree1 = new BinaryTree<int>(56);
                    objTree1.Insert(30);
                    objTree1.Insert(70);
                    Console.WriteLine("Binary Search Tree is Shown Below :- ");
                    objTree1.Display();
                    break;
                case 0:
                    return;
                    
                default:
                    Console.WriteLine("Please Enter Correct Question Number");
                    break;


            }

            Console.ReadKey();
        }
    }
}