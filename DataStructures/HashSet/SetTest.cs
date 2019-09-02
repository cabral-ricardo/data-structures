using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class SetTest
    {
        public static void PrintActions()
        {
            var set = new Set();

            // Adiciona no conjunto
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Adiciona no conjunto");
            Console.WriteLine("-------------------------\r\n");
            set.Add("Mauricio");
            set.Add("Marcelo");
            set.Add("Jose");
            Console.WriteLine($"{set}");

            // Remove no conjunto
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Remove do conjunto");
            Console.WriteLine("-------------------------\r\n");
            set.Remove("Mauricio");
            Console.WriteLine($"{set}");

            // Adiciona no hashset
            Console.WriteLine("\r\n-------------------------");
            var set1 = new Set();
            Console.WriteLine($"Adiciona no hashset");
            Console.WriteLine("-------------------------\r\n");
            set1.AddHashSet("Ricardo");
            set1.AddHashSet("Rodrigo");
            set1.AddHashSet("Joao");
            Console.WriteLine($"{set1}");

            // Hash code
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Hash code");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"Ricardo".GetHashCode());
            Console.WriteLine($"Ricardo".GetHashCode());
            Console.WriteLine($"Rodrigo".GetHashCode());
            Console.WriteLine("-------------------------\r\n");
        }
    }
}
