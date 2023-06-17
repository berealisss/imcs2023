using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("input.txt");
        int n = int.Parse(lines[0]); // Количество студентов
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        for (int i = 1; i <= n; i++)
        {
            string[] parts = lines[i].Split('\t');
            string group = parts[0];
            string name = parts[1];

            if (!groups.ContainsKey(group))
            {
                groups.Add(group, new List<string>());
            }

            groups[group].Add(name);
        }

        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            foreach (string group in groups.Keys.OrderBy(g => g))
            {
                writer.WriteLine(group);

                foreach (string name in groups[group].OrderBy(n => n))
                {
                    writer.WriteLine(name);
                }
            }
        }
    }
}
