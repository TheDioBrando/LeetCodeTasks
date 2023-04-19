namespace LeetCodeTasks.Medium
{
    public class SolutionLowestCommonAncestor
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {

            int low = Math.Min(q.val, p.val);
            int high = Math.Max(q.val, p.val);
            while (root != null)
            {
                if (root.val < low)
                    root = root.right;
                else if (root.val > high)
                    root = root.left;
                else
                    return root;
            }
            return null;
        }
    }
}
