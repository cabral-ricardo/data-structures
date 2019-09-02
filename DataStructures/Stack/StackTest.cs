using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public static class StackTest
    {
        public static void PrintActions()
        {
            var stackRoot = new StackRoot();

            // Add with linked list
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Insere na lista com LinkedList");
            Console.WriteLine("-------------------------\r\n");
            stackRoot.AddWithLinkedList("Mauricio");
            Console.WriteLine($"{stackRoot}");
            stackRoot.AddWithLinkedList("Guilherme");
            Console.WriteLine($"{stackRoot}");

            // Remove of list
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Remove da lista");
            Console.WriteLine("-------------------------\r\n");

            Console.WriteLine($"Lista completa:");
            Console.WriteLine($"{stackRoot}");
            Console.WriteLine("-------------------------\r\n");
            stackRoot.Remove();
            stackRoot.Remove();
            Console.WriteLine($"{stackRoot}");

            // Check empty list
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Verifica lista vazia");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"{stackRoot.isEmpty()}");

            // Add with stack
            var stack = new Stack();
            Console.WriteLine("\r\n-------------------------");            
            Console.WriteLine($"Insere na lista com Stack");
            Console.WriteLine("-------------------------\r\n");
            stack.Add("Mauricio");
            Console.WriteLine($"{stack}");
            stack.Add("Guilherme");
            Console.WriteLine($"{stack}");

            // Remove stack
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Remove com Stack");
            Console.WriteLine("-------------------------\r\n");
            Console.WriteLine($"Peek: {stack.Peek()}");
            stack.Remove();
            Console.WriteLine($"Peek: {stack.Peek()}");
            stack.Remove();
            Console.WriteLine($"{stack}");
        }
    }
}
