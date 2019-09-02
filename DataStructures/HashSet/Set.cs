using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Set
    {
        private List<LinkedList<string>> table = new List<LinkedList<string>>();
        HashSet<string> newTable = new HashSet<string>();

        public Set()
        {
            for (int i = 0; i < 26; i++)
            {
                table.Add(new LinkedList<string>());
            }
        }

        public void Add(string word)
        {
            int idex = CalculateIndexOfTable(word);
            var list = table[idex];
            list.AddLast(word);
        }

        public void AddHashSet(string palavra)
        {
            newTable.Add(palavra);
        }

        public void Remove(string word)
        {
            if (Contains(word))
            {
                int index = CalculateIndexOfTable(word);
                var list = table[index];
                list.Remove(word);
            }
        }
        
        private int CalculateIndexOfTable(string word)
        {
            var initialLetter = Convert.ToChar(word.ToLower().Substring(0, 1));
            var asciiCode = Convert.ToInt32(initialLetter);
            return asciiCode % 26;
        }

        private bool Contains(string word)
        {
            int index = CalculateIndexOfTable(word);
            var list = table[index];
            return list.Contains(word);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var items in table)
            {
                sb.Append("[");
                foreach (var item in items)
                {
                    sb.Append(item);
                    sb.Append(",");
                }
                sb.Append("]");
            }

            sb.Append("]");

            sb.Append("[");
            foreach (var item in newTable)
            {
                sb.Append(item);
                sb.Append(",");
            }
            sb.Append("]");

            return sb.ToString();
        }

    }
}
