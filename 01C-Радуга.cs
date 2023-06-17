using System;
using System.Text;

namespace Rainbow 
{
    class Color 
    {
        static void Main(string[] args) 
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            Console.WriteLine("Красный");
            Console.WriteLine("Оранжевый");
            Console.WriteLine("Желтый");
            Console.WriteLine("Зеленый");
            Console.WriteLine("Голубой");
            Console.WriteLine("Синий");
            Console.Write("Фиолетовый");
        }
    }
}
