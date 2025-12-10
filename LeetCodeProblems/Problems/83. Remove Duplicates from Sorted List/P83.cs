using LeetCodeProblems.Models;

namespace LeetCodeProblems.Problems.P83;

/// <summary>
/// 83. Remove Duplicates from Sorted List
/// </summary>
internal class P83
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var node = head;

        while (node != null && node.next != null)
        {
            if (node.val == node.next.val)
            {
                node.next = node.next.next; 
            }
            else
            {
                node = node.next;
            }                
        }

        return head;
    }
}
