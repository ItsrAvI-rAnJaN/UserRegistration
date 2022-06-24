using System;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t******** WELCOME TO USER REGESTRATION PROGRAM ********");
            while (true)
            {
                Console.WriteLine("\n1. Please Enter Valid First Name");
                Console.WriteLine("2. Please Enter Valid Last Name");
                Console.WriteLine("3. Please Enter Valid Email");
                Console.WriteLine("4. Please Enter Valid Mobile Number Starting With Country Code");
                Console.WriteLine("5. Please Enter Valid Password having Minimum 8 Character");
                Console.WriteLine("6. Please Enter Valid Password having at Least one Upper Case ");
                Console.WriteLine("7. Please Enter Valid Password having at least one Numeric ");
                Console.WriteLine("8. please Enter valid Password having at least one Special Character");
                Console.WriteLine("9. Test All Sample Emails Provided Separately ");
                Console.WriteLine("Enter 0 for Exit ");
                Console.Write("Please Enter Your Choice : ");

                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Validation objFirstName = new Validation();
                        Console.WriteLine(objFirstName.Name("First"));
                        break;
                    case 2:
                        Validation objLastName = new Validation();
                        Console.WriteLine(objLastName.Name("Last"));
                        break;
                    case 3:
                        Validation objEmail = new Validation();
                        Console.WriteLine("abc+100@gmail.com : " + objEmail.Email("abc+100@gmail.com"));
                        Console.WriteLine("abc@gmail.com.aa.au : " + objEmail.Email("abc@gmail.com.aa.au"));
                        break;
                    case 4:
                        Validation objPhone = new Validation();
                        Console.Write("Enter country code with Mobile number for validation (give a space between them) : ");
                        string enteredMobileNumber = Console.ReadLine();
                        Console.WriteLine(objPhone.Mobile(enteredMobileNumber));
                        break;
                    case 5:
                        Validation objPass1 = new Validation();
                        Console.WriteLine(objPass1.Password1());
                        break;
                    case 6:
                        Validation objPass2 = new Validation();
                        Console.WriteLine(objPass2.Password2());
                        break;
                    case 7:
                        Validation objPass3 = new Validation();
                        Console.WriteLine(objPass3.Password3());
                        break;
                    case 8:
                        Validation objPass4 = new Validation();
                        Console.Write("Enter password for validation : ");
                        string enteredPassword = Console.ReadLine();
                        Console.WriteLine(objPass4.Password4(enteredPassword));
                        break;
                    case 9:
                        Validation objTestEmails = new Validation();
                        objTestEmails.EmailsTest();                         
                        break;

                    case 0:
                         return;
                    default:
                        Console.WriteLine("Please Enter Correct Choice");
                        break ;
                        
                }
            }
            Console.ReadKey();
        }
    }
}