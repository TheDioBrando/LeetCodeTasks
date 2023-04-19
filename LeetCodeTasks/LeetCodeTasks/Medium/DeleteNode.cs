namespace LeetCodeTasks.Medium
{
    public class SolutionDeleteNode
    {
        public void DeleteNode(ListNode node)
        {
            var nextNode = node.next;
            node.next = nextNode.next;
            node.val = nextNode.val;
        }
    }
}
