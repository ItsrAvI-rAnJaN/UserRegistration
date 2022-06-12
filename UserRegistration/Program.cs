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
                        Console.WriteLine(objEmail.Email("Email"));
                        break;
                    case 4:
                        Validation objPhone = new Validation();
                        Console.WriteLine(objPhone.MobileNumber());
                        break;
                    case 5:
                        Validation objPass1 = new Validation();
                        Console.WriteLine(objPass1.Password1());
                        break;
                    case 6:
                        Validation objPass2 = new Validation();
                        Console.WriteLine(objPass2.Password2());
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