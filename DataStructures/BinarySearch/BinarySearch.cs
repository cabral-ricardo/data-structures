namespace DataStructures
{
    public class BinarySearch
    {
        // Returns index of x if it is present in arr[l..r], else return -1 
        public int Search(int[] arrayOrigin, int position, int index, int valueResearch)
        {
            if (index >= position)
            {
                int middle = position + (index - position) / 2;

                // If the element is present at the middle itself 
                if (arrayOrigin[middle] == valueResearch)
                    return middle;

                // If element is smaller than mid, then it can only be present in left subarray 
                if (arrayOrigin[middle] > valueResearch)
                    return Search(arrayOrigin, position, middle - 1, valueResearch);

                // Else the element can only be present in right subarray 
                return Search(arrayOrigin, middle + 1, index, valueResearch);
            }

            // We reach here when element is not present 
            // in array 
            return -1;
        }
    }
}
