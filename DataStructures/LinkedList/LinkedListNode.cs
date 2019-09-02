namespace DataStructures
{
    public class LinkedListNode
    {
        public Node head; // head of list

        // Linked list node. This inner class is made static so that main() can access it
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
    }
}
