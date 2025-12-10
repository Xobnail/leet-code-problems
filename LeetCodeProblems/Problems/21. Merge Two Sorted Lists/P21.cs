using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems.P21;

/// <summary>
/// 21. Merge Two Sorted Lists
/// </summary>
/// <remarks>
/// Можно решить с помощью одной рекурсии.
/// </remarks>
internal class P21
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
        {
            return list2;
        }

        if (list2 == null)
        {
            return list1;
        }

        Insert(ref list1, list2.val);
        MergeTwoLists(list1, list2.next);

        return list1;
    }

    public void Insert(ref ListNode list, int target)
    {
        if (list.next == null)
        {
            if (list.val <= target)
            {
                list.next = new ListNode(target, list.next);
            }
            else
            {
                list.next = new ListNode(list.val);
                list.val = target;
            }

            return;
        }

        if (target < list.val)
        {
            list = new ListNode(target, list);

            return;
        }

        if (list.val <= target && target < list.next.val)
        {
            list.next = new ListNode(target, list.next);

            return;
        }        

        if (target >= list.next.val)
        {
            Insert(ref list.next, target);
        }
    }
}