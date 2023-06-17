using System;

namespace Shift
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int[] arr = new int[n];
            string[] elements = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(elements[i]);
            }

            for (int i = 0; i < k; i++)
            {
                int temp = arr[0];
                for (int j = 0; j < n - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[n - 1] = temp;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
