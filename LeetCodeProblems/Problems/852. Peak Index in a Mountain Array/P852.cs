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
            int m = l + (r - l + 1) / 2;

            if (arr[m - 1] < arr[m])
            {
                l = m;
            }
            else
            {
                r = m - 1;
            }
        }

        return l;
    }
}