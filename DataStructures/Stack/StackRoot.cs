using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class StackRoot
    {
        private LinkedList<string> names = new LinkedList<string>();
        Stack<string> stack = new Stack<string>();

        public void AddWithLinkedList(string name)
        {
            names.AddLast(name);
        }

        public void AddWithStack(string name)
        {
            stack.Push(name);
        }

        public void Remove()
        {
            for (LinkedListNode<string> item = names.First; item != null; item = item.Next)
            {
                if (item.Next == null)
                {
                    Console.WriteLine($"{item.Value} removido");
                    names.Remove(item);
                    break;
                }
            }
        }

        public bool isEmpty()
        {
            return names.Count == 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            foreach (var item in names)
            {
                sb.Append(item);
                sb.Append(",");

            }
            
            sb.Append("]");
            return sb.ToString();
            
        }
    }
}
