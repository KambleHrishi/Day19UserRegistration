using System.Text.RegularExpressions;

namespace Day19UserRegistration
{
    public class Program
    {
        public static void Main(string[]args)
        {
            string inStr = Console.ReadLine();

            string firstName = @"^[A-Z]{1}[a-zA-Z]{2,9}$";

            Regex regex = new Regex(firstName);
            Console.WriteLine(regex.IsMatch(inStr));
        }
    }
}