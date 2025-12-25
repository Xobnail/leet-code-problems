using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._107._Binary_Tree_Level_Order_Traversal_II;

/// <summary>
/// 107. Binary Tree Level Order Traversal II
/// </summary>
internal class P107
{
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        if (root == null)
        {
            return [];
        }

        Queue<TreeNode> q = [];
        q.Enqueue(root);
        LinkedList<IList<int>> result = [];

        while (q.Count > 0)
        {
            int levelLength = q.Count;
            IList<int> level = [];

            for (int i = 0; i < levelLength; i++)
            {
                TreeNode node = q.Dequeue();

                level.Add(node.val);

                if (node.left != null)
                {
                    q.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    q.Enqueue(node.right);
                }
            }

            result.AddFirst(level);
        }

        return new List<IList<int>>(result);
    }
}
