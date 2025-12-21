using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._2095._Delete_the_Middle_Node_of_a_Linked_List;

/// <summary>
/// 2095. Delete the Middle Node of a Linked List
/// </summary>
internal class P2095
{
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head.next == null) return null;

        ListNode dummy = head;
        ListNode fast = head;

        fast = fast.next.next;

        while (fast?.next != null)
        {
            head = head.next;
            fast = fast.next.next;
        }

        head.next = head.next.next;

        return dummy;
    }
}
