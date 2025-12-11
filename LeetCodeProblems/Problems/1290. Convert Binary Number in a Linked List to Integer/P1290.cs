using LeetCodeProblems.Models;
using System.Text;

namespace LeetCodeProblems.Problems._1290._Convert_Binary_Number_in_a_Linked_List_to_Integer;

/// <summary>
/// 1290. Convert Binary Number in a Linked List to Integer
/// </summary>
internal class P1290
{
    public int GetDecimalValue(ListNode head)
    {
        int result = 0;

        while (head != null)
        {
            result = result << 1 | head.val;
            head = head.next;
        }

        return result;
    }

    // По методу Горнера
    //public int GetDecimalValue(ListNode head)
    //{
    //    int result = 0;

    //    while (head != null)
    //    {
    //        result = result * 2 + head.val;
    //        head = head.next;
    //    }

    //    return result;
    //}

    //public int GetDecimalValue(ListNode head)
    //{
    //    Stack<int> values = new();

    //    while (head != null)
    //    {
    //        values.Push(head.val);
    //        head = head.next;
    //    }

    //    int result = 0;

    //    for (int i = 0; values.TryPop(out int value); i++)
    //    {
    //        result += value * (int)Math.Pow(2, i);
    //    }

    //    return result;
    //}

    //public int GetDecimalValue(ListNode head)
    //{
    //    StringBuilder sb = new();

    //    while (head != null)
    //    {
    //        sb.Append(head.val);
    //        head = head.next;
    //    }

    //    return Convert.ToInt32(sb.ToString(), 2);
    //}
}
