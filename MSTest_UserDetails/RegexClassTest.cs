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
                Console.WriteLine(data + " is a Valid First Name");
                return "validName";
            }
            else
            {
                Console.WriteLine(data + " is a Invalid First Name");
                return "invalidName";
            }
        }
    }
}
