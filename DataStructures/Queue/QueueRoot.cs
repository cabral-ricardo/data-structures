using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class QueueRoot
    {
        private LinkedList<string> students = new LinkedList<string>();

        public void Add(string student)
        {
            students.AddFirst(student);
        }

        public void Remove()
        {
            for (LinkedListNode<string> item = students.First; item != null; item = item.Next)
            {
                if (item.Next == null)
                {
                    Console.WriteLine($"Aluno Removido: {item.Value}");
                    students.Remove(item);
                    break;
                }
            }
        }

        public bool isEmpty()
        {
            return students.Count == 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in students)
            {
                sb.Append(item);
                sb.Append(",");
            }

            sb.Append("]");
            return sb.ToString();
        }
    }
}
