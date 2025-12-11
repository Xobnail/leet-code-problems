namespace LeetCodeProblems.Problems._189._Rotate_Array;

/// <summary>
/// 189. Rotate Array
/// </summary>
internal class P189
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;

        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    public void Reverse(int[] nums, int start, int end)
    {
        for (; start < end; start++, end--)
        {
            nums[start] += nums[end];
            nums[end] = nums[start] - nums[end];
            nums[start] -= nums[end];
        }
    }

    //public void Rotate(int[] nums, int k)
    //{
    //    k %= nums.Length;

    //    int[]a = new int[k];
    //    int[]b = new int[nums.Length - k];

    //    for (int i = 0; i < nums.Length - k; i++)
    //    {
    //        b[i] = nums[i];
    //    }

    //    for (int i = nums.Length - k, j = 0; i < nums.Length; i++, j++)
    //    {
    //        a[j] = nums[i];
    //    }

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        if (i < k)
    //        {
    //            nums[i] = a[i];
    //        }
    //        else
    //        {
    //            nums[i] = b[i - k];
    //        }
    //    }
    //}

    // Правильный ответ, но не проходит большие тест кейсы
    //public void Rotate(int[] nums, int k)
    //{
    //    for (int l = 0; l < k; l++)
    //    {
    //        int buf = nums[nums.Length - 1];

    //        for (int i = nums.Length - 1; i >= 1; i--)
    //        {
    //            nums[i] = nums[i - 1];
    //        }

    //        nums[0] = buf;
    //    }
    //}
}
