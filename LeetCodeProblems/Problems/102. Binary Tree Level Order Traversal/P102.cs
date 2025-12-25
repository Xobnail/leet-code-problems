using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._102._Binary_Tree_Level_Order_Traversal;

/// <summary>
/// 102. Binary Tree Level Order Traversal
/// </summary>
internal class P102
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null)
        {
            return [];
        }

        Queue<TreeNode> q = [];
        q.Enqueue(root);
        IList<IList<int>> result = [];

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

            result.Add(level);
        }

        return result;
    }
}
