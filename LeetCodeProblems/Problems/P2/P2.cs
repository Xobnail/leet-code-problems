namespace LeetCodeProblems.Problems.P2;

/// <summary>
/// 2. Add Two Numbers
/// </summary>
internal class P2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var result = new ListNode();
        var n1 = l1;
        var n2 = l2;
        var r = result;
        int mem = 0;

        while (true)
        {
            var n1val = n1?.val ?? 0;
            var n2val = n2?.val ?? 0;

            if (n1val + n2val + mem >= 10)
            {
                r.val = (n1val + n2val + mem) % 10;
                mem = (n1val + n2val + mem) / 10;
            }
            else
            {
                r.val = (n1val + n2val + mem);
                mem = 0;
            }

            if (n1?.next == null && n2?.next == null && mem == 0) break;

            r.next = new ListNode();
            r = r.next;
            n1 = n1?.next;
            n2 = n2?.next;
        }

        return result;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}