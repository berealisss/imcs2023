using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int gcdAB = GCD(a, b);
            int gcdAC = GCD(a, c);
            int gcdBC = GCD(b, c);
            Console.WriteLine($"{gcdAB} {gcdAC} {gcdBC}");
        }
        
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
