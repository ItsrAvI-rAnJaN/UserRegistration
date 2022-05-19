using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // create class in this Defining Method for Address Book System..
    internal class AddressBook
    {
        // creating String & Int Type  Variable to Store Details
        string First_Name;
        string Last_Name;
        string Address;
        string City;
        string State;
        int Zip_Code;
        long Phone_Number;
        string Email_Address;

        // Defining Paramterized Method/Function or instance Method
        public void ContactDetails(string First_Name, string Last_Name,String Address,string City, string State,int Zip_Code,long Phone_number,string Email_Address)
        {
            // printg Details..
            Console.WriteLine("\nContact Details are :-");
            Console.WriteLine("Name : {0} {1}", First_Name, Last_Name);
            Console.WriteLine("Address : {0}, {1} ({2})",Address,City,State);
            Console.WriteLine("Zip Code : {0}", Zip_Code);
            Console.WriteLine("Ph. Number : {0}", Phone_number);
            Console.WriteLine("Email Address : {0}", Email_Address);
        }
    }
}
