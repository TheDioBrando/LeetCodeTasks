namespace LeetCodeTasks.Medium
{
    public class SolutionValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
                return true;
            var stack = new Stack<TreeNode>();
            var curr = root;
            TreeNode prev = null;
            while (curr != null || stack.Count > 0)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                if (prev != null && prev.val >= curr.val)
                    return false;
                prev = curr;
                curr = curr.right;
            }
            return true;
        }
    }
}
