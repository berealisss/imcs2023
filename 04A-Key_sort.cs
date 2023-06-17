using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        var sortedWords = words.OrderBy(w => w[1]);
        string output = string.Join(" ", sortedWords);

        Console.WriteLine(output);
    }
}
