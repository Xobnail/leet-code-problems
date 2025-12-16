namespace LeetCodeProblems.Problems._1337._The_K_Weakest_Rows_in_a_Matrix;

/// <summary>
/// 1337. The K Weakest Rows in a Matrix
/// </summary>
internal class P1337
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        PriorityQueue<int, (int, int)> pQueue = new();

        for (int i = 0; i < mat.Length; i++)
        {
            pQueue.Enqueue(i, (GetAmountOfOnes(mat[i]), i));
        }

        var result = new int[k];

        for (int i = 0; i < k; i++)
        {
            result[i] = pQueue.Dequeue();
        }

        return result;
    }

    public int GetAmountOfOnes(int[] nums)
    {
        int l = 0;
        int r = nums.Length - 1;

        while (l < r)
        {
            int m = (l + r) / 2;

            if (nums[m] > 0)
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }

        return nums[l] > 0 ? l + 1 : l;
    }

    //public int[] KWeakestRows(int[][] mat, int k)
    //{
    //    int[,] ones = new int[mat.Length, 2];
    //    int[] result = new int[k];

    //    for (int i = 0; i < mat.Length; i++)
    //    {
    //        ones[i, 0] = i;
    //        ones[i, 1] = GetAmountOfOnes(mat[i]);
    //    }

    //    int[,] sOnes = BubbleSort(ones);

    //    for (int i = 0; i < k; i++)
    //    {
    //        result[i] = sOnes[i, 0];
    //    }

    //    return result;
    //}

    //public int GetAmountOfOnes(int[] nums)
    //{
    //    int l = 0;
    //    int r = nums.Length - 1;

    //    while (l < r)
    //    {
    //        int m = (l + r) / 2;

    //        if (nums[m] > 0)
    //        {
    //            l = m + 1;
    //        }
    //        else
    //        {
    //            r = m;
    //        }
    //    }

    //    return nums[l] > 0 ? l + 1 : l;
    //}

    //public int[,] BubbleSort(int[,] nums)
    //{
    //    for (int i = nums.GetLength(0) - 1; i >= 0; i--)
    //    {
    //        for (int j = 0; j < i; j++)
    //        {
    //            if (nums[j, 1] > nums[j + 1, 1] || (nums[j, 1] == nums[j + 1, 1] && nums[j, 0] > nums[j + 1, 0]))
    //            {
    //                nums[j, 1] += nums[j + 1, 1];
    //                nums[j + 1, 1] = nums[j, 1] - nums[j + 1, 1];
    //                nums[j, 1] -= nums[j + 1, 1];
    //                nums[j, 0] += nums[j + 1, 0];
    //                nums[j + 1, 0] = nums[j, 0] - nums[j + 1, 0];
    //                nums[j, 0] -= nums[j + 1, 0];
    //            }
    //        }
    //    }

    //    return nums;
    //}
}
