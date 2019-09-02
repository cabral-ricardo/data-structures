using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Queue
    {
        Queue<string> students = new Queue<string>();

        public void Add(string student)
        {
            students.Enqueue(student);
        }

        public void Remove()
        {
            Console.WriteLine($"Aluno Removido...");
            students.Dequeue();
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
