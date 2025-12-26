using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._24._Swap_Nodes_in_Pairs;

/// <summary>
/// 24. Swap Nodes in Pairs
/// </summary>
internal class P24
{
    public ListNode SwapPairs(ListNode head)
    {
        return Swap(head, null);
    }

    public ListNode Swap(ListNode head, ListNode prev)
    {
        if (head == null)
        {
            return null;
        }

        if (head.next == null)
        {
            return head;
        }

        if (prev != null)
        {
            prev.next = head.next;
        }

        ListNode first = head.next;
        ListNode nexpPair = head.next.next;
        head.next.next = head;
        head.next = nexpPair;

        Swap(nexpPair, head);

        return first;
    }
}
