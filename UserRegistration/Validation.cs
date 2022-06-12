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

            Console.Write("\nEnter {0} Name for Validation : ",name);
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

    }
}
