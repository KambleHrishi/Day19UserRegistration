using System.Text.RegularExpressions;

namespace Day19UserRegistration
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter last name");
            string inStr = Console.ReadLine();

            string lastName = @"^[A-Z]{1}[a-zA-Z]{2,9}$";

            Regex regex = new Regex(lastName);
            Console.WriteLine(regex.IsMatch(inStr));
        }
    }
}