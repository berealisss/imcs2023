using System;

namespace Count
{
    class Program
    {
        static void Main()
        {
            string input = File.ReadAllText("d.in").Trim();
            Regex wordRegex = new Regex(@"\b\w[\w-]*\b");
            int count = wordRegex.Matches(input).Count;
            File.WriteAllText("d.out", count.ToString());
        }
    }
}
