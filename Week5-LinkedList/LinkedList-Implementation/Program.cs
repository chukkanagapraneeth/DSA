using System.Text;

namespace LinkedList_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.Add("Ram");
            linkedList.Add("Praneeth");
            linkedList.Print();
        }

        public class LinkedList<T> 
        {
            private class Node
            {
                public T Data { get; set; }
                public Node Next { get; set; }
                public Node(T data)
                {
                    Data = data;
                    Next = null;
                }
            }

            private Node head;
            private int count;

            public LinkedList()
            {
                head = null;
                count = 0;
            }

            public void Add(T data)
            {
                Node newNode = new Node(data);
                if(head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node currentNode = head;
                    while(currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Next = newNode;
                }
                count++;
            }

            public void Print()
            {
                StringBuilder sb = new StringBuilder();
                Node currentNode = head;
                while(currentNode != null)
                {
                    sb.Append(currentNode.Data).Append(" ---> ");
                    currentNode = currentNode.Next;
                }
                sb.Append("null");

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
