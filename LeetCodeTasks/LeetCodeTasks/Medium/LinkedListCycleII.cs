namespace LeetCodeTasks.Medium
{
    public class SolutionLinkedListCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            var slow = head; var fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    break;
            }
            if (fast == null || fast.next == null)
                return null;
            while (head != slow)
            {
                head = head.next;
                slow = slow.next;
            }
            return head;
        }
    }
}
