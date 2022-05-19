using System;

namespace AddressBookSystem
{
    public class Program
    {
        // Create Static Main Method 
        static void Main(string[] args)
        {
            // printing Welcome Message
            Console.WriteLine("\t\t\t******* WELCOME TO ADDRESS BOOK SYSTEM PROGRAM ******");

            // creating Instance/Object of Class AddressBook
            AddressBook objdetails = new AddressBook();

            // Calling Method & Giving Parameters
            objdetails.ContactDetails("Ravi", "Ranjan", "DLF Phase 4", "Gurugram", "Haryana", 122002, 9319964621, "Ezekie.em@gmail.com");

            // For Holding Output Terminal
            Console.ReadKey();
        }
    }
}