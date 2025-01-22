namespace ReverseLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example Test Case
            int[] values = { 1, 2, 3, 4, 5 };
            var program = new Program();
            ListNode head = program.CreateLinkedList(values);

            Console.WriteLine("Original Linked List:");
            program.PrintLinkedList(head);

            Solution solution = new Solution();
            ListNode reversedHead = solution.ReverseList(head);

            Console.WriteLine("Reversed Linked List:");
            program.PrintLinkedList(reversedHead);
        }

        // Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            public ListNode ReverseList(ListNode head)
            {
                if (head == null) return null;

                ListNode currentNode = head;
                ListNode previousNode = null;

                while (currentNode != null)
                {
                    ListNode nextNode = currentNode.next;
                    currentNode.next = previousNode;
                    previousNode = currentNode;
                    currentNode = nextNode;
                }

                return previousNode;
            }
        }

        // Helper Method: Create a linked list from an array
        public ListNode CreateLinkedList(int[] values)
        {
            if (values.Length == 0) return null;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }

        // Helper Method: Print a linked list
        public void PrintLinkedList(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.val);
                if (current.next != null)
                {
                    Console.Write(" -> ");
                }
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
