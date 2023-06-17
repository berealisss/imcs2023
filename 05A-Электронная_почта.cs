using System;

class Program
{
    static void Main(string[] args)
    {
        string lastName = Console.ReadLine();
        string firstName = Console.ReadLine();
        string role = Console.ReadLine();

        string email = $"{lastName}.{firstName}@{role}.dvfu.ru";

        Console.WriteLine(email);
    }
}
