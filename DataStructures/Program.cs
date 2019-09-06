using DataStructures.HashTable;
using System;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------Linked List-------");
            Console.WriteLine("-------------------------");
            LinkedList();
            Console.WriteLine("");
            Console.WriteLine("-------------------------");

            Console.WriteLine("-------------------------");
            Console.WriteLine("----Doubly Linked List----");
            DoublyLinkedList();
            Console.WriteLine("");
            Console.WriteLine("-------------------------");

            Console.WriteLine("-------------------------");
            Console.WriteLine("------Linear Search------");
            LinearSearch();
            Console.WriteLine("");
            Console.WriteLine("-------------------------");

            Console.WriteLine("-------------------------");
            Console.WriteLine("------Binary Search------");
            BinarySearch();
            Console.WriteLine("");
            Console.WriteLine("-------------------------");

            Console.WriteLine("-------------------------");
            Console.WriteLine("-----------Vetor---------");
            Vetor();
            Console.WriteLine("");
            Console.WriteLine("-------------------------");

            Console.WriteLine("-------------------------");
            Console.WriteLine("-----------Stack---------");
            Stack();
            Console.WriteLine("");

            Console.WriteLine("-------------------------");
            Console.WriteLine("-----------Queue---------");
            Queue();
            Console.WriteLine("");

            Console.WriteLine("-------------------------");
            Console.WriteLine("----------Set-------");
            Set();
            Console.WriteLine("");

            Console.WriteLine("-------------------------");
            Console.WriteLine("----------Hash Table-------");
            HashTable();
            Console.WriteLine("");
        }

        #region  Linked List
        private static void LinkedList()
        {
            var linkedList = new LinkedListNode();
            linkedList.head = new LinkedListNode.Node(1);
            LinkedListNode.Node second = new LinkedListNode.Node(2);
            LinkedListNode.Node third = new LinkedListNode.Node(3);

            linkedList.head.next = second;
            second.next = third;

            PrintList(linkedList.head);
            Push(4, linkedList.head);

            LinkedListTest.PrintActions();
        }

        private static void PrintList(LinkedListNode.Node node)
        {
            while (node != null)
            {
                Console.WriteLine($"Nó: {node.data} ");
                node = node.next;
            }
        }

        private static void Push(int newData, LinkedListNode.Node head)
        {
            var newNode = new LinkedListNode.Node(newData);
            newNode.next = head;
            head = newNode;
        }
        #endregion

        #region  Doubly Linked List
        private static void DoublyLinkedList()
        {
            DoubleLinkedListTest.RetornarListaElementos();
        }
        #endregion

        #region Linear Serach
        private static void LinearSearch()
        {
            int[] arr = { 2, 3, 4, 7, 9, 10, 15, 18, 40 };
            int index = 7;

            var linearSearch = new LinearSearch();

            int result = linearSearch .Search(arr, index);
            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result);
        }
        #endregion

        #region Binary Search
        private static void BinarySearch()
        {
            int[] arr = { 2, 3, 4, 7, 9, 10, 15, 18, 40 };
            int size = arr.Length;
            int item = 7;

            var binarySerach = new BinarySearch();
            int result = binarySerach.Search(arr, 0, size - 1, item);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index " + result);
        }
        #endregion

        #region Vetor
        private static void Vetor()
        {
            VetorTest.PrintActions();
        }

        #endregion

        #region Stack
        private static void Stack()
        {
            StackTest.PrintActions();
        }
        #endregion

        #region Queue
        private static void Queue()
        {
            QueueRootTest.PrintActions();
            QueueTest.PrintActions();
        }
        #endregion

        #region Set
        private static void Set()
        {
            SetTest.PrintActions();
        }
        #endregion

        #region HashTable
        private static void HashTable()
        {
            HashTableTest.PrintActions();
        }
        #endregion
    }
}
