using System;

namespace DataStructures
{
    public static class LinkedListTest
    {
       public static void PrintActions()
        {
            var list = new LinkedList();

            // Add in beginning
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Adiciona no começo: ");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{list}");
            list.AddBeginning("mauricio");
            Console.WriteLine($"{list}");
            list.AddBeginning("paulo");
            Console.WriteLine($"{list}");
            list.AddBeginning("guilherme");
            Console.WriteLine($"{list}");
            Console.WriteLine("-------------------------");

            // Add in end
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Adiciona no fim");
            Console.WriteLine("-------------------------\r\n");
            list.Add("marcelo");
            Console.WriteLine($"{list}");
            Console.WriteLine("-------------------------");

            // Add in middle
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Adiciona no meio");
            Console.WriteLine("-------------------------\r\n");
            list.Add(2, "gabriel");
            Console.WriteLine($"{list}");
            Console.WriteLine("-------------------------");

            // Get element
            Console.WriteLine("\r\n-------------------------");
            var position = 2;
            Console.WriteLine($"Obter elemento: {position}");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{list.Get(position)}");
            Console.WriteLine("-------------------------");

            // Get size elements
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Obter total de elementos:");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{list.GetSizeItems()}");
            Console.WriteLine("-------------------------");

            // Remove in beginning
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Remove elemento do começo");
            Console.WriteLine("-------------------------\r\n");
            list.RemoveBeginning();
            Console.WriteLine($"{list}");
            Console.WriteLine("-------------------------");
        }

    }
}
