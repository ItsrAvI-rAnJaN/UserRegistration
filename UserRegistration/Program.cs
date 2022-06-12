﻿using System;

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