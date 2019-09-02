using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinearSearch
    {
        public int Search(int[] arr, int index)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == index)
                    return i;
            }
            return -1;
        }
    }
}
