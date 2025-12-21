using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._19._Remove_Nth_Node_From_End_of_List;

/// <summary>
/// 19. Remove Nth Node From End of List
/// </summary>
internal class P19
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.next == null) return null;
        if (head.next.next == null && n == 1) return new ListNode(head.val);

        ListNode fast = head;
        ListNode dummy = head;

        for (int i = 0; i < n; i++)
        {
            fast = fast?.next;
        }

        if (fast == null) return head.next;

        while (fast.next != null)
        {
            head = head.next;
            fast = fast.next;
        }

        head.next = head.next.next;

        return dummy;
    }
}
