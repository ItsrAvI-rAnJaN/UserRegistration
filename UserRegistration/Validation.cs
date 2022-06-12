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

            Console.Write("Enter {0}Name for Validation : ",name);
            string EnteredName = Console.ReadLine();

            //if Name Enter By User is match with Expression  then Valid if not Then Inva;id 
            return Regex.IsMatch(EnteredName, REGEX_FIRSTNAME) ? (name + " Name is Valid") : (name + " Name is Invalid");
        }
    }
}
