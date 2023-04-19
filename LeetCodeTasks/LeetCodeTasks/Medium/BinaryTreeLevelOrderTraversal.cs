namespace LeetCodeTasks.Medium
{
    public class SolutionBinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();

            var result = new List<IList<int>>
            {
                new List<int>() { root.val }
            };
            TraverseTree(root.left, result, 0);
            TraverseTree(root.right, result, 0);

            return result;
        }

        public void TraverseTree(TreeNode node, List<IList<int>> tree, int level)
        {
            if (node == null)
                return;
            if (tree.Count == ++level)
                tree.Add(new List<int>());
            tree[level].Add(node.val);

            TraverseTree(node.left, tree, level);
            TraverseTree(node.right, tree, level);
        }
    }
}
