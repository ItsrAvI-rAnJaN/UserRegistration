using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class Stacks
    {
        internal Node Head;

        // intialized head to null

        public Stacks()
        {
            this.Head = null;
        }
         // Create Method to Add Data to the Stack one by one
        internal void Push(int Value)
        {
            Node NewNode = new Node(Value);
            if (this.Head == null)
            {
                NewNode.next = null;

            }
            else
            {
                NewNode.next = Head;
            }
            this.Head = NewNode;
            Console.WriteLine("{0} is Add to the Stacks",NewNode.Value);
        }

        // for Dislplaying Stacks
        internal void display()
        {
            if (this.Head == null)
            {
                Console.WriteLine(" Stacks is Empty");
                return;
            }
            Console.WriteLine("The Stacks is:");
            Console.Write("Head:");
            Node TempNode = this.Head;
            
            while(TempNode != null)
            {
                Console.WriteLine(TempNode.Value + " ");
                TempNode = TempNode.next;
            }
            
        }
    }
}
