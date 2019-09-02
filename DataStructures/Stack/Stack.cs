using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack
    {
        Stack<string> stack = new Stack<string>();
      
        public void Add(string name)
        {
            stack.Push(name);
        }

        public void Remove()
        {
            stack.Pop();
        }

        public string Peek()
        {
            return stack.Peek();
        }

        public bool isEmpty()
        {
            return stack.Count == 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            foreach (string item in stack)
            {
                sb.Append(item);
                sb.Append(",");

            }

            sb.Append("]");
            return sb.ToString();

        }
    }
}
