using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class Validation
    {
        public string Name(string name)
        {
            //Regular Expression for Validation of First Name
            string REGEX_FIRSTNAME = "^[A-Z][A-Za-z]{2,8}$";

            Console.Write("\nEnter {0} Name for Validation : ", name);
            string EnteredName = Console.ReadLine();

            //if Name Enter By User is match with Expression  then Valid if not Then Inva;id 
            return Regex.IsMatch(EnteredName, REGEX_FIRSTNAME) ? (name + " Name is Valid") : (name + " Name is Invalid");
        }

        // Method for regular  Validation of  email
        public string Email(string email)
        {
            string REGEX_EMAIL = "^([A-Za-z]){3,}([_.+-]{1}[0-9A-Za-z]{1,}){0,}@[a-z0-9]+[.](com|net){0,1}([.]((com)|([a-z]{2}){0,1})){0,1}$";

            Console.Write("Enter Email Name for validation : ");
            string enteredEmail = Console.ReadLine();
            return Regex.IsMatch(enteredEmail, REGEX_EMAIL) ? "Email is valid" : "Email is invalid";
        }
        // method for Validation of Mobile Number
        public string MobileNumber()
        {
            string REGEX_CELLNO = "^[+][1-9]{1,3}[ ][6-9]{1}[0-9]{9}$";

            Console.Write("Enter Mobile Number Starting With Country Code : ");
            string enteredMobileNumber = Console.ReadLine();
            return Regex.IsMatch(enteredMobileNumber, REGEX_CELLNO) ? "Mobile Number is valid" : "Mobile Number is invalid";

        }
        // Method for Validation of Password 1
        public string Password1()
        {
            string REGEX_PASSWORD = "^.{8,}$";

            Console.Write("Enter Password for validation : ");
            string EnteredPassword = Console.ReadLine();
            return Regex.IsMatch(EnteredPassword, REGEX_PASSWORD) ? "Password is Valid" : "Password is Invalid";
        }
        public string Password2()
        {
            //Regular expression to match previous condition + atleast one Upper Case
            string REGEX_PASSWORD = "^(?=.*[A-Z]).{8,}$";

            Console.Write("Enter password for validation : ");
            string EnteredPassword = Console.ReadLine();
            return Regex.IsMatch(EnteredPassword, REGEX_PASSWORD) ? "Password is valid" : "Password is Invalid";
        }
        // Method For Password 3 having at least One Numeric Value
        public string Password3()
        {
            string REGEX_PASSWORD = "^(?=.*[A-Z0-9]).{8,}$";

            Console.Write("Enter password for validation : ");
            string EnteredPassword = Console.ReadLine();
            return Regex.IsMatch(EnteredPassword, REGEX_PASSWORD) ? "Password is Valid" : "Password is Invalid";
        }


    }
}
