using System;

namespace StackAndQueues
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t******** WELCOME TO STACK AND QUEUES PROGRAM ********");

            int Choice;
            do
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1. Create Stack of 56 ->30->70");
                Console.Write("Enter Your Choice :");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Stacks objStack = new Stacks();
                        objStack.Push(70);
                        objStack.Push(30);
                        objStack.Push(56);
                        objStack.display();
                        break;

                    default:
                        Console.WriteLine("please Enter Correct Choice");
                        break;

                }

            }
            while (Choice != 0);



            Console.ReadKey();
        }
    }
}