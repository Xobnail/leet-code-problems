using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._1721._Swapping_Nodes_in_a_Linked_List;

/// <summary>
/// 1721. Swapping Nodes in a Linked List
/// </summary>
internal class P1721
{
    public ListNode SwapNodes(ListNode head, int k)
    {
        ListNode slow = head;
        ListNode fast = head;

        for (int i = 1; i < k; i++)
        {
            fast = fast.next;
        }

        ListNode left = fast;

        while (fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        int temp = left.val;
        left.val = slow.val;
        slow.val = temp;

        return head;
    }

    //public ListNode SwapNodes(ListNode head, int k)
    //{
    //    ListNode left = head;
    //    ListNode right = head;

    //    for (int i = 1; i < k; i++)
    //    {
    //        left = left.next;
    //    }

    //    ListNode rightHead = Reverse(head);
    //    right = rightHead;

    //    for (int i = 1; i < k; i++)
    //    {
    //        right = right.next;
    //    }

    //    int temp = left.val;
    //    left.val = right.val;
    //    right.val = temp;

    //    return Reverse(rightHead);
    //}

    //public ListNode Reverse(ListNode head)
    //{
    //    ListNode prev = null;
    //    ListNode curr = head;

    //    while (curr != null)
    //    {
    //        ListNode next = curr.next;
    //        curr.next = prev;
    //        prev = curr;
    //        curr = next;
    //    }

    //    return prev;
    //}
}
