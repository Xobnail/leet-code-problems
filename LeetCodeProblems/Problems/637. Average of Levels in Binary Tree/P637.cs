using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._637._Average_of_Levels_in_Binary_Tree;

/// <summary>
/// 637. Average of Levels in Binary Tree
/// </summary>
internal class P637
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        Queue<TreeNode> q = [];
        q.Enqueue(root);
        IList<double> result = [];

        while (q.Count > 0)
        {
            int levelLength = q.Count;
            double sum = 0;

            for (int i = 0; i < levelLength; i++)
            {
                TreeNode node = q.Dequeue();
                sum += node.val;

                if (node.left != null)
                {
                    q.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    q.Enqueue(node.right);
                }
            }

            result.Add(sum / levelLength);
        }

        return result;
    }
}
