namespace PalindromeLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int val=0, ListNode next=null) {
         *         this.val = val;
         *         this.next = next;
         *     }
         * }
         */
        public class Solution
        {
            public bool IsPalindrome(ListNode head)
            {
                List<int> li = new();
                ListNode currentNode = head;
                while (currentNode != null)
                {
                    li.Add(currentNode.val);
                    currentNode = currentNode.next;
                }

                int start = 0;
                int end = li.Count - 1;

                while (start < end)
                {
                    if (li[start] != li[end])
                    {
                        return false;
                    }
                    start++; end--;
                }

                return true;
            }
        }
    }
}
