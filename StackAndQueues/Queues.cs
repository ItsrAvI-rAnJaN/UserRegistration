using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class Queues
    {
        internal Node Head = null;

        // Insert in The Node At The End of The Queues
        internal void Enqueue(int Data)
        {
            Node NewNode = new Node(Data);

            //Queue is Empty Insert in New Node At First Position
            if (Head == null)
            {
                Head = NewNode;
            }
            //Otherwise Insert at The End of Queue
            else
            {
                Node TempHead = Head;
                while (TempHead.next != null)
                {
                    TempHead = TempHead.next;
                }
                TempHead.next = NewNode;
            }
            Console.WriteLine("{0} is Insert in to The Queue", NewNode.Value);

        }
        internal void Dequeues()
        {
            if (Head == null)
            {
                Console.WriteLine("Queue is Empty ");
            }
            else
            {
                Console.WriteLine("\n{0} Deleted from the queue",Head.Value);

                // Assing to the Next Node.
                Head = Head.next;
            }
        }


        //For Displaying Nodes
        internal void Display()
        {
            if (Head == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                // Printing Queues.
                Console.Write("The Queue is : Head");  
                Node TempHead = Head;
                while (TempHead != null)
                {
                    Console.Write(" -> {0}" ,TempHead.Value);
                    TempHead = TempHead.next;
                }
                Console.WriteLine(" <- Tail\n");
            }
        }
    }
}
