using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSTest_UserDetails
{
    internal class CustomException
    {
        public enum ValidationMessage
        {
            InvalidFirstName, InvalidLastName,
            InvalidEmailId, InvalidMobileNumber,
            InvalidPassword,
            InvalidSampleEmailId
        }
        public readonly ValidationMessage Type;

        public CustomException(ValidationMessage Type, string message)
        {
            this.Type = Type;
        }
    }
    public class UserRegistration
    {
        public string CustomExceptionFirstName(string message)
        {
            try
            {
                string firstname = "^[A-Z]{1}[a-z]{2,}$";
                Regex regex = new Regex(firstname);

                if (regex.IsMatch(message))
                {
                    Console.Write("Name is Valid\n");
                    return "Name is Valid";
                }
                else
                {
                    Console.WriteLine("Name is Invalid\n");
                    return "invalidName";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
            return default(String);
        }
    }
}
