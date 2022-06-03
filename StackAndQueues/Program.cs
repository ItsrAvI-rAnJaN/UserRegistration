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
                Console.WriteLine("\n0.Exit");
                Console.WriteLine("1. Create Stack of 56 ->30->70");
                Console.WriteLine("2. Peek and Pop till Stack is Empty ");
                Console.WriteLine("3. Create Queue of 56->30->70");
                Console.WriteLine("4. Dequeue/Delete data starting of the Queue ");
                Console.Write("Enter Your Choice : ");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Stacks objStack = new Stacks();
                        objStack.Push(70);
                        objStack.Push(30);   // Adding Data in Stacks.
                        objStack.Push(56);
                        objStack.display();
                        break;

                    case 2:
                        Stacks objStack1 = new Stacks();
                        objStack1.Push(70);
                        objStack1.Push(30);
                        objStack1.Push(56);
                        objStack1.display();

                        // peek & Pop 1st
                        objStack1.Peek();
                        objStack1.Pop();
                        Console.WriteLine("After pop 1st");
                        objStack1.display();

                        // Peek & Pop 2nd
                        objStack1.Peek();
                        objStack1.Pop();
                        Console.WriteLine("After pop 2nd");
                        objStack1.display();

                        // Peek & Pop 3rd
                        objStack1.Peek();
                        objStack1.Pop();
                        Console.WriteLine("After pop 3rd");
                        objStack1.display();

                        break;

                    case 3:
                        Queues objQueues = new Queues();
                        objQueues.Enqueue(56);   
                        objQueues.Enqueue(30);    // Adding Data in Queues..
                        objQueues.Enqueue(70);
                        objQueues.Display();
                        break;
                    case 4:
                        Queues objQueues1 = new Queues();
                        objQueues1.Enqueue(56);
                        objQueues1.Enqueue(30);  // Adding to The Queue.
                        objQueues1.Enqueue(70);

                        // Deleting From Queue 1st
                        objQueues1.Dequeues();
                        objQueues1.Display();

                        // Deleting From Queue 2nd
                        objQueues1.Dequeues();
                        objQueues1.Display();

                        // Deleting From Queue 3rd
                        objQueues1.Dequeues();
                        objQueues1.Display();

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