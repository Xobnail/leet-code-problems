namespace LeetCodeProblems.Problems._852._Peak_Index_in_a_Mountain_Array;

/// <summary>
/// 852. Peak Index in a Mountain Array
/// </summary>
internal class P852
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        int l = 1;
        int r = arr.Length - 1;

        while (l < r)
        {
            int m = (l + r) / 2;

            if (arr[m - 1] < arr[m])
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }

        return l - 1;
    }
}