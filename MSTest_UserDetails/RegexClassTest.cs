using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSTest_UserDetails
{
    public class RegexClassTest
    {
        public string FirstName(string data)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {               
                Console.WriteLine(data + " is a Valid First Name");              
                return "validName";
            }
            else
            {               
                Console.WriteLine(data + " is a Invalid First Name");
                return "invalidName";
            }
        }
        public string LastName(string data)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.WriteLine(data + " is a Valid Last Name");
                return "validName";
            }
            else
            {
                Console.WriteLine(data + " is a Invalid Last Name");
                return "invalidName";
            }
        }
        public string Email(string data)
        {

            string pattern = "^[a-zA-z0-9]+[.]{0,1}[a-zA-z0-9]+([@]?)+[a-z]{1,15}[.]+(com|co)+((.in)*)$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.WriteLine(data + " is a Valid Email ID");
                return "validEmail";
            }
            else
            {
                Console.WriteLine(data + " is a Invalid Email ID");
                return "invalidEmail";
            }
        }

        public string Mobile(string data)
        {
            string pattern = "^[6-9]{2}[0-9]{8}?$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.WriteLine(data + " is a Valid Phone Number");
                return "validMob";
            }
            else
            {
                Console.WriteLine(data + " is a Invalid Phone Number");
                return "invalidMob";
            }
        }
        public string Password(string data)
        {
            string pattern = "^((?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%&])).{8,}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.WriteLine(data + " is a Valid Password");
                return "validPassword";
            }
            else
            {
                Console.WriteLine(data + " is a Invalid Password");
                return "invalidPassword";
            }
        }
        public string EmailSample(string id)
        {
            string emailFormat = "[A-Za-z0-9](.[-+a-z0-9A-Z])+@[A-Za-z0-9]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex1 = new Regex(emailFormat);
            if (regex1.IsMatch(id))
            {
                Console.Write(id + " is Valid \n");
                return "validEmailSample";
            }
            else
            {
                Console.Write("Email Is Invalid!\nPlease Enter Email ID in Proper Format \n");
                return "invalidEmailSample";
            }
        }
    }
}
