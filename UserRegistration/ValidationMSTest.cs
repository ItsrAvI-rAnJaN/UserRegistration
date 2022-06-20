using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class ValidationMSTest
    {

        string REGEX_NAME = "^[A-Z][A-Za-z]{2,}$";

        string REGEX_EMAIL = "^([A-Za-z]){3,}(([_.+-]?)([0-9A-Za-z]{1,}))*@[a-z0-9]+[.](com|net){0,1}([.]((com)|([a-z]{2}){0,1})){0,1}$";

        string REGEX_MOBIlENO = "^[1-9]{1,3}[ ][6-9]{1}[0-9]{9}$";

        string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";

        public string Name(string name)
        {
            Regex regex = new Regex(REGEX_NAME);

            bool result = regex.IsMatch(name);
            if (result)
            {
                return name;
            }
            else
            {
                return default;
            }
        }

        public string Email(string email)
        {
            Regex regex = new Regex(REGEX_EMAIL);

            bool result = regex.IsMatch(email);
            if (result)
            {
                return email;
            }
            else
            {
                return default;
            }
        }

        public string Mobile(string mobile)
        {
            Regex regex = new Regex(REGEX_MOBIlENO);

            bool result = regex.IsMatch(mobile);
            if (result)
            {
                return mobile;
            }
            else
            {
                return default;
            }
        }

        public string Password(string password)
        {
            Regex regex = new Regex(REGEX_PASSWORD);

            bool result = regex.IsMatch(password);
            if (result)
            {
                return password;
            }
            else
            {
                return default;
            }
        }
    }
}
