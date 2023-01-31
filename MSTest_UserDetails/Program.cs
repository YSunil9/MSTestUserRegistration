namespace MSTest_UserDetails
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome To Regex User Registration Problem");
            RegexClassTest obj = new RegexClassTest();
            Console.WriteLine("1.First Name\n2.Last Name\n3.Email\n4.Mobile\n5.Password\n6.Email Sample");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Enter First Name");
                    string firstName = Console.ReadLine();
                    obj.FirstName(firstName);
                    break;
                case 2:
                    Console.WriteLine("Enter Last Name");
                    string LastName = Console.ReadLine();
                    obj.LastName(LastName);
                    break;
                case 3:
                    Console.WriteLine("Enter EmailId");
                    string id = Console.ReadLine();
                    obj.Email(id);
                    break;
                case 4:
                    Console.WriteLine("Enter Mobile Number");
                    string no = Console.ReadLine();
                    obj.Mobile(no);
                    break;
                case 5:
                    Console.WriteLine("Enter Password");
                    string pswd = Console.ReadLine();
                    obj.Password(pswd);
                    break;
                case 6:
                    Console.WriteLine("Enter Email Id");
                    string email = Console.ReadLine();
                    obj.EmailSample(email);
                    break;
            }
        }
    }
}