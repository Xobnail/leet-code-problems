namespace LeetCodeProblems.Problems.P2529;

/// <summary>
/// 2529. Maximum Count of Positive Integer and Negative Integer
/// </summary>
internal class P2529
{
    public int MaximumCount(int[] nums)
    {
        int firstNeg = FirstNeg(nums);
        int firstPos = FirstPos(nums);
        var length = nums.Length;

        if (firstNeg != -1 && firstPos != -1)
        {
            var amountOfPos = length - firstPos;
            var amountOfNeg = firstNeg + 1;

            return amountOfPos > amountOfNeg ? amountOfPos : amountOfNeg;
        }
        else if (firstNeg == -1 && firstPos != -1)
        {
            return length - firstPos;
        }
        else if (firstNeg != -1 && firstPos == -1)
        {
            return firstNeg + 1;
        }
        else
        {
            return 0;
        }
    }

    public int FirstNeg(int[] nums)
    {
        int length = nums.Length;
        int result = -1;
        int right = length != 0 ? length - 1 : 0;
        int left = 0;

        while (left <= right)
        {
            var i = (right + left) / 2;

            if (nums[i] >= 0)
            {
                right = i - 1;
            }
            else if (nums[i] < 0)
            {
                left = i + 1;
                result = i;
            }
        }

        return result;
    }

    public int FirstPos(int[] nums)
    {
        int length = nums.Length;
        int result = -1;
        int right = length != 0 ? length - 1 : 0;
        int left = 0;

        while (left <= right)
        {
            var i = (right + left) / 2;

            if (nums[i] <= 0)
            {
                left = i + 1;
            }
            else if (nums[i] > 0)
            {
                right = i - 1;
                result = i;
            }
        }

        return result;
    }
}
