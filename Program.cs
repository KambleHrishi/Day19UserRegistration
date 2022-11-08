using System.Text.RegularExpressions;

namespace Day19UserRegistration
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter Email ID");
            string inStr = Console.ReadLine();
            
            string emailId = @"^[a-zA-Z0-9]+[._+-]{0,1}[a-zA-Z0-9]@[a-zA-Z0-9]{1,10}.[a-zA-Z]{2,10}[.][a-zA-Z]";

            Regex regex = new Regex(emailId);
            Console.WriteLine(regex.IsMatch(inStr));
        }
    }
}