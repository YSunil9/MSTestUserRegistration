namespace MSTest_UserDetails
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RegexClassTest obj = new RegexClassTest();
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            obj.FirstName(firstName);
        }
    }
}