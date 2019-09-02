using System;

namespace DataStructures
{
    public class DoubleLinkedListTest
    {
        public static void RetornarListaElementos()
        {
            var list = new DoubleLinkedList();

            // Add beggining list 
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Adiciona no começo");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{list}");
            list.AddBeginning("mauricio");
            Console.WriteLine($"{list}");
            list.AddBeginning("paulo");
            Console.WriteLine($"{list}");
            list.AddBeginning("guilherme");
            Console.WriteLine($"{list}");

            // Add in end
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Adiciona no fim");
            Console.WriteLine("-------------------------\r\n");
            list.Add("marcelo");
            Console.WriteLine($"{list}");

            // Add in middle
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Adiciona no meio");
            Console.WriteLine("-------------------------\r\n");
            list.Add(2, "gabriel");
            Console.WriteLine($"{list}");

            // Remove in end
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Remove do fim");
            Console.WriteLine("-------------------------\r\n");
            list.RemoveEnd();
            Console.WriteLine($"{list}");

            // Remove in middle
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Remove do meio");
            Console.WriteLine("-------------------------\r\n");
            list.Remove(1);
            Console.WriteLine($"{list}");

            // Get element
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Contem elemento:");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{list.Contains("mauricio")}");
            Console.WriteLine($"{list.Contains("joaquim")}");
            Console.WriteLine("-------------------------\r\n");

            // Get Element by position
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Obter elemento:");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{list.Get(2)}");

            // Get size elements
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Obter total de elementos:");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{list.GetSizeItems()}");

            // Remove do começo
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Remove elemento do começo");
            Console.WriteLine("-------------------------\r\n");
            list.RemoveBeginning();
            Console.WriteLine($"{list}");
        }
    }
}
