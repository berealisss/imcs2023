using System;

namespace SentType
{
    class Program
    {
        public static void Main(string[] args)
        {
            string myString = Console.ReadLine();

            bool containsQuestionExclamationMark = myString.Contains("?!");
            bool containsQuestionMark = myString.Contains("?");
            bool containsExclamationMark = myString.Contains("!");
            bool containsCommaMark = myString.Contains(",");

            if (containsQuestionExclamationMark = myString.Contains("?!")) 
            {
                if (containsCommaMark = myString.Contains(",")) 
                {
                    Console.WriteLine("сложное вопросительно-восклицательное");
                }
                else 
                {
                    Console.WriteLine("вопросительно-восклицательное");
                }
            }
            else if (containsQuestionMark = myString.Contains("?")) 
            {
               if (containsCommaMark = myString.Contains(",")) 
               {
                    Console.WriteLine("сложное вопросительное");
               }
               else 
               {
                    Console.WriteLine("вопросительное");
               }
            }
            else if (containsExclamationMark = myString.Contains("!")) 
            {
                if (containsCommaMark = myString.Contains(",")) 
                {
                    Console.WriteLine("сложное восклицательное");
                }
                else 
                {
                    Console.WriteLine("восклицательное");
                }
            }
            else 
            {
                if (containsCommaMark = myString.Contains(",")) 
                {
                    Console.WriteLine("сложное повествовательное");
                }
                else 
                {
                    Console.WriteLine("повествовательное");
                }
            }
        }
    }
}
