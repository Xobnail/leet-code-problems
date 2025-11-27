namespace LeetCodeProblems.Trees;

public class TreeFunctions
{
    public static TreeNode BuildTree(int?[] nums)
    {
        if (nums.Length == 0 || nums[0] == null)
        {
            return null;
        }

        TreeNode root = new TreeNode(nums[0].Value);
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        int i = 1;

        while (q.Count > 0 && i < nums.Length)
        {
            TreeNode currentNode = q.Dequeue();

            if (i < nums.Length && nums[i] != null)
            {
                currentNode.left = new TreeNode(nums[i].Value);

                q.Enqueue(currentNode.left);
            }

            i++;

            if (i < nums.Length && nums[i] != null)
            {
                currentNode.right = new TreeNode(nums[i].Value);

                q.Enqueue(currentNode.right);
            }

            i++;
        }

        return root;
    }
}
