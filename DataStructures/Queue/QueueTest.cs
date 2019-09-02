using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public static class QueueTest
    {
        public static void PrintActions()
        {
            var queue = new Queue();

            // Add Queue
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Insere na lista com Queue");
            Console.WriteLine("-------------------------\r\n");
            queue.Add("Mauricio");
            queue.Add("Guilherme");
            queue.Add("Jose");
            Console.WriteLine($"{queue}");

            // Remove Queue
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Remove daa lista com Queue");
            Console.WriteLine("-------------------------\r\n");
            queue.Remove();
            Console.WriteLine($"{queue}");
            queue.Remove();
            Console.WriteLine($"{queue}");

            // Check empty queue
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Valida Queue vazia");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{queue.isEmpty()}");
            queue.Remove();
            Console.WriteLine($"{queue.isEmpty()}");


        }
    }
}
