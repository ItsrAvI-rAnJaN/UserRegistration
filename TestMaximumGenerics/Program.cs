using System;

namespace TestMaximumGenerics
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t******** WELCOME TO FIND MAXIMUM PROBLEM USING GENERICS ********");

            int Choice;
            do
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Find Maximum Among Three Integer");
                Console.Write("Enter Your Choice : ");
                Choice=Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        FindMaxInt objFindMaxInt =new FindMaxInt();

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(30, 20, 10));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(10, 30, 20));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(10, 20, 30));

                        break;
                }
            } while(Choice !=0);

            Console.ReadKey();
        }
    }
}