using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._2130._Maximum_Twin_Sum_of_a_Linked_List;

/// <summary>
/// 2130. Maximum Twin Sum of a Linked List
/// </summary>
internal class P2130
{
    public int PairSum(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;
        ListNode first = head;
        int result = 0;

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode last = Reverse(slow);

        while (last != null)
        {
            if (first.val + last.val > result)
            {
                result = first.val + last.val;
            }

            first = first.next;
            last = last.next;
        }

        return result;
    }

    public ListNode Reverse(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;
        
        while (curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }

    //public int PairSum(ListNode head)
    //{
    //    ListNode fast = head;
    //    Stack<int> lefts = [];
    //    int result = 0;

    //    while (fast?.next != null)
    //    {
    //        lefts.Push(head.val);
    //        head = head.next;
    //        fast = fast.next.next;
    //    }

    //    while (head != null)
    //    {
    //        int left = lefts.Pop();

    //        if (left + head.val > result)
    //        {
    //            result = left + head.val;
    //        }

    //        head = head.next;
    //    }

    //    return result;
    //}
}
