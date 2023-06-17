using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1, rev;
            string1 = Console.ReadLine();
            string1 = string1.Replace(" ", "");
            char[] ch = string1.ToCharArray();

            Array.Reverse(ch);
            rev = new string(ch);

            bool a = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
          
            if (a == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
