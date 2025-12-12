using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._206._Reverse_Linked_List;

/// <summary>
/// 206. Reverse Linked List
/// </summary>
internal class P206
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var newHead = ReverseList(head.next);

        head.next.next = head;
        head.next = null;

        return newHead;
    }

    //public ListNode ReverseList(ListNode head)
    //{
    //    ListNode curr = head;
    //    ListNode prev = null;
    //    ListNode next = null;

    //    while (curr != null)
    //    {
    //        next = curr.next;
    //        curr.next = prev;
    //        prev = curr;
    //        curr = next;
    //    }

    //    return prev;
    //}

    //public ListNode ReverseList(ListNode head)
    //{
    //    if (head == null)
    //    {
    //        return null;
    //    }

    //    ListNode result = new();

    //    Traverse(head, ref result);

    //    return result;
    //}

    //public ListNode Traverse(ListNode node, ref ListNode result)
    //{
    //    if (node.next == null)
    //    {
    //        result = new ListNode(node.val);
    //        return result;
    //    }

    //    var res = Traverse(node.next, ref result);

    //    res.next = new ListNode(node.val);

    //    return res.next;
    //}

    //public ListNode ReverseList(ListNode head)
    //{
    //    Stack<int> list = new();

    //    while (head != null)
    //    {
    //        list.Push(head.val);
    //        head = head.next;
    //    }

    //    if (!list.TryPeek(out _))
    //    {
    //        return null;
    //    }

    //    ListNode result = new(list.Pop());
    //    ListNode dummy = result;

    //    while (list.TryPop(out int value))
    //    {
    //        dummy.next = new ListNode(value);
    //        dummy = dummy.next;
    //    }

    //    return result;
    //}
}
