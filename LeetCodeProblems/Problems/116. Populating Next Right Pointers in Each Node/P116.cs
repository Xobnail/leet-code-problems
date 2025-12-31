namespace LeetCodeProblems.Problems._116._Populating_Next_Right_Pointers_in_Each_Node;

/// <summary>
/// 116. Populating Next Right Pointers in Each Node
/// </summary>
internal class P116
{
    public Node Connect(Node root)
    {
        if (root?.left == null)
        {
            return root;
        }

        root.left.next = root.right;
        root.right.next = root.next?.left;

        Connect(root.left);
        Connect(root.right);

        return root;
    }
}

public class Node
{
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
