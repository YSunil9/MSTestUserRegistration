namespace MSTest_UserDetails
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome To Regex User Registration Problem");
            RegexClassTest obj = new RegexClassTest();
            Console.WriteLine("1.First Name\n2.Last Name\n3.Email\n");
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
            }
        }
    }
}