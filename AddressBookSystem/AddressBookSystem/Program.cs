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

            int Choice;
            do
            {
                // taking output from user to Executed the Program
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Get Contact Present in Address Book ");
                Console.WriteLine("2.Add New Contact to Address Book");
                Console.WriteLine("3.Edit Contact Present in Address Book");
                Console.WriteLine("4.Delete Contact Using Person's First Name");
                Console.WriteLine("5. Add Multiple Contact Addresss");
                Console.Write("Enter Your Choice : ");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        // creating Instance/Object of Class AddressBook & setting Parameters value..
                        AddressBook objdetails = new AddressBook("Ravi", "Ranjan", "DLF Phase 4", "Gurugram", "Haryana", 122002, 9319964621, "Ezekie.em@gmail.com");

                        // Calling Method Define in Address Class to Displaying Details.
                        objdetails.DisplayContactDetails();
                        break;
                    case 2:
                        ContactPerson objaddnewcontact = new ContactPerson();
                        objaddnewcontact.AddNewContact();
                        objaddnewcontact.DisplayContactDetails();
                        break;
                    case 3:
                        // creating instance & call the Method to Add New Contact
                        ContactPerson objeditcontact = new ContactPerson();
                        objeditcontact.AddNewContact();
                        objeditcontact.DisplayContactDetails();

                        // for Editing Contact & call the Method of Editing Contact
                        Console.WriteLine("Edit Contact Using first Name ?  Y/N"); // asking for Edit or Not..
                        Console.Write("Enter Your Choice : ");
                        string Choice_3 = Console.ReadLine();
                        if (Choice_3 == "Y")
                        {
                            objeditcontact.EditContactDetails();
                            objeditcontact.DisplayContactDetails();
                        }
                        break;
                    case 4:
                        // Creting instance of call the Method to Edit & Delete Contactg Details.
                        ContactPerson objDeleteAddress =  new ContactPerson();
                        objDeleteAddress .AddNewContact();
                        objDeleteAddress.DisplayContactDetails();

                        // Asking to Edit Contact if Y then Proceed.
                        Console.WriteLine("Edit Contact Using first Name ? Y/N");
                        Console.Write("Enter Your Choice : "); 
                        string Choice4_1 = Console.ReadLine();
                        if (Choice4_1 == "Y")
                        {
                            objDeleteAddress.EditContactDetails();
                            objDeleteAddress.DisplayContactDetails();
                        }

                        // Asking to delete the Contact Details if Y then Proceed..
                        Console.WriteLine(" Delete Contact Using First Name ? Y/N");
                        Console.Write("Enter Your Choice : ");
                        string Choice4_2 = Console.ReadLine();
                        if (Choice4_2 == "Y")
                        {
                            objDeleteAddress.DeleteContactDetails();
                        }
                        else
                        {
                            objDeleteAddress.DisplayContactDetails();
                        }
                        break;
                    case 5:
                        AddMultiContatcs objMultiContact =new AddMultiContatcs();
                    Add:
                        Console.WriteLine("Enter Details Below ?: Y/N ");
                        Console.WriteLine("Enter Your Choice : ");
                        string Choice5_1 = Console.ReadLine();
                        if (Choice5_1 == "Y")
                        {
                            objMultiContact.AddMultiNewContact();
                            objMultiContact.DisplayContactDetails();
                            goto Add;
                        }
                    // Asking User to Edit Contact Details.
                    Edit:
                        if (objMultiContact.AddressList.Count > 0) //Check no. of Contact is greater than 0.
                        {
                            Console.WriteLine("Edit Contact Using first Name ? Y/N");
                            Console.Write("Enter Your Choice : ");
                            string Choice5_2 = Console.ReadLine();
                            if (Choice5_2 == "Y")
                            {
                                objMultiContact.EditContactDetails();
                                objMultiContact.DisplayContactDetails();
                                goto Edit;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Contact Details Not Present in Address Book");
                        }
                    Delete:
                        if(objMultiContact.AddressList.Count > 0)
                        {
                            // Asking to delete the Contact Details if Y then Proceed..
                            Console.WriteLine(" Delete Contact Using First Name ? Y/N");
                            Console.Write("Enter Your Choice : ");
                            string Choice5_2 = Console.ReadLine();
                            if (Choice5_2 == "Y")
                            {
                                objMultiContact.EditContactDetails();
                                objMultiContact.DisplayContactDetails();
                                goto Delete;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Contact Details Not Present in Address Book for Deletion..");

                        }
                        break;
                    default:
                        Console.WriteLine("Enter Correct Choice");
                        break;
                }

            }
            while (Choice != 0);

            // To Hold Output Terminal
            Console.ReadKey();


        }
    }
}