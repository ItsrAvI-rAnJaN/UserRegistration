using System;

namespace TestMaximumGenerics
{
    class program
    {
        // Main Method
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t******** WELCOME TO FIND MAXIMUM PROBLEM USING GENERICS ********");

            int Choice; //Creating Variable to Store Input From User
            do
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Find Maximum Among Three Integer");
                Console.Write("Enter Your Choice : ");
                Choice=Convert.ToInt32(Console.ReadLine()); // store iput From User & Convert Into Integer type

                // Using Switch Case To Excute Prgram Input by User
                switch (Choice)
                {
                    case 1:

                        // Creating Instance of Class FindMaxInt
                        FindMaxInt objFindMaxInt =new FindMaxInt();

                        // printing Max Int No. AMong Three
                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(30, 20, 10));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(10, 30, 20));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(10, 20, 30));

                        break;
                }
            } while(Choice !=0);

            //TO Hold OutPut Terminal
            Console.ReadKey();
        }
    }
}