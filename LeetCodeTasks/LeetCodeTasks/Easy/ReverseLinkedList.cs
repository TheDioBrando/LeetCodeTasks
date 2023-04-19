namespace LeetCodeTasks.Easy
{
    public class SolutionReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode result = null;
            ListNode temp;
            while (head != null)
            {
                temp = head;
                head = head.next;
                temp.next = result;
                result = temp;
            }

            return result;
        }
    }
}
