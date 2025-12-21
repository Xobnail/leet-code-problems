using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems._876._Middle_of_the_Linked_List;

/// <summary>
/// 876. Middle of the Linked List
/// </summary>
internal class P876
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    //public ListNode MiddleNode(ListNode head)
    //{
    //    List<ListNode> list = new();

    //    while (head != null)
    //    {
    //        list.Add(head);
    //        head = head.next;
    //    }

    //    return list[list.Count / 2];
    //}
}
