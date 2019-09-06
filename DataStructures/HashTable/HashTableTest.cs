using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.HashTable
{
    public static class HashTableTest
    {
        public static void PrintActions()
        {
            var hashTable = new HashTable();
            var random = new Random();

            // Add in array
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Insere na lista com Hash Table");
            Console.WriteLine("-------------------------\r\n");
            hashTable.AddByArray("Mauricio", random.Next(100));
            hashTable.AddByArray("Guilherme", random.Next(100));
            hashTable.AddByArray("Jose", random.Next(100));
            Console.WriteLine($"{hashTable}");

            // Add 
            var hashTableNew = new HashTable();
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Insere na lista com Hash Table");
            Console.WriteLine("-------------------------\r\n");
            hashTableNew.Add("Ricardo", random.Next(100));
            hashTableNew.Add("Cabral", random.Next(100));
            hashTableNew.Add("Rafa", random.Next(100));
            Console.WriteLine($"{hashTableNew}");

            // Exception
            var hashTableExcetion = new HashTable();
            Console.WriteLine("\r\n-------------------------");
            Console.WriteLine($"Gera Exception Hash Table");
            Console.WriteLine("-------------------------\r\n");
            hashTableExcetion.Add("Ricardo", random.Next(100));
            hashTableExcetion.Add("Rafa", random.Next(100));
            //hashTableExcetion.Add("Ricardo", random.Next(100));
            Console.WriteLine($"{hashTableExcetion}");
        }
    }
}
