namespace LinearDataStructuresDemo
{
    public class MyLinkedList
    {
        private Node head;

        public void Push(int newData)
        {
            Node newNode = new Node(newData);

            newNode.next = head;

            head = newNode;
        }

        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

            Console.WriteLine();
        }


        public void RemoveDuplicates()
        {
        }

        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }
    }
}