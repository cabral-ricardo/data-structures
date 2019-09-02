using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class QueueRootTest
    {   
        public static void PrintActions()
        {
            var queue = new QueueRoot();

            // Add in queue
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Insere na lista com Fila");
            Console.WriteLine("-------------------------\r\n");
            queue.Add("Mauricio");
            queue.Add("Guilherme");
            queue.Add("Jose");
            Console.WriteLine($"{queue}");

            // Remove queue
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Remove daa lista com Fila");
            Console.WriteLine("-------------------------\r\n");
            queue.Remove();
            Console.WriteLine($"{queue}");
            queue.Remove();
            Console.WriteLine($"{queue}");

            // Check empty list 
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Valida Fila vazia");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{queue.isEmpty()}");
            queue.Remove();
            Console.WriteLine($"{queue.isEmpty()}");


        }
    }
}
