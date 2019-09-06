using System;
using System.Collections;
using System.Text;

namespace DataStructures.HashTable
{
    public class HashTable
    {
        Hashtable _hashTable = new Hashtable();

        public void AddByArray(string name, int age)
        {
            _hashTable[name] = age;            
        }

        public void Add(string name, int age)
        {
            _hashTable.Add(name, age);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (DictionaryEntry element in _hashTable)
            {
                sb.Append("[");
                var name = (string)element.Key;
                int age = (int)element.Value;
                sb.Append($"Nome:{name}, Idade:{age}");
                sb.Append("]\r\n");
            }
                       
            return sb.ToString();
        }
    }
}
