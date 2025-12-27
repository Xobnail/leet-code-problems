using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._234._Palindrome_Linked_List;

/// <summary>
/// 234. Palindrome Linked List
/// </summary>
internal class P234
{
    public bool IsPalindrome(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next?.next;
        }

        ListNode end = Reverse(slow);

        while (end != null)
        {
            if (head.val != end.val)
            {
                return false;
            }

            end = end.next;
            head = head.next;
        }

        return true;
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
}
