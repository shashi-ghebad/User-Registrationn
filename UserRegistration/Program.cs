using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UC1_ValidName
{
    class Program
    {
        public static string userName;

        public static bool UserName(string userName)
        {
            return Regex.IsMatch(userName, @"^[A-Z]{1}[a-zA-Z0-9]{2,}$");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Valid User Name: ");
            userName = Console.ReadLine();
            Console.WriteLine(UserName(userName));
            Console.ReadKey();
        }
    }
}







