namespace MiddleOfTheLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
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
            public ListNode MiddleNode(ListNode head)
            {
                if (head == null)
                {
                    return null;
                }

                ListNode slowNode = head;
                ListNode fastNode = head;

                // We need fastNode != null condition when there are even numbers as If fastNode.next is null, this line will throw a NullReferenceException -> (null).next
                // We need fastNode.next != null  condition when odd numbers are there as if fastNode is null then fastNode.next throws null exception

                while (fastNode != null && fastNode.next != null)
                {
                    slowNode = slowNode.next;
                    fastNode = (fastNode.next).next;
                }

                return slowNode;
            }
        }
    }
}
