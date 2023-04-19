namespace LeetCodeTasks.Easy
{
    public class SolutionNaryTreePreorderTraversal
    {
        public IList<int> Preorder(Node root)
        {

            var tree = new List<int>();
            if (root == null)
                return tree;
            var stack = new Stack<Node>();

            stack.Push(root);
            while (stack.Count != 0)
            {
                var temp = stack.Pop();
                tree.Add(temp.val);
                for (int i = temp.children.Count - 1; i >= 0; i--)
                {
                    stack.Push(temp.children[i]);
                }
            }
            return tree;
        }
    }
}
