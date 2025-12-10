namespace LeetCodeProblems.Problems.P9;

/// <summary>
/// 9. Palindrome Number
/// </summary>
internal class P9
{
    public bool IsPalindrome(long x)
    {
        if (x < 0) return false;

        long[] nums;
        int count = 1;

        for (long i = 10; i <= 10_000_000_000; i *= 10) // because 2^31-1 has 10 digits
        {
            if (x / i == 0) break;

            count++;
        }

        if (count == 1) return true;

        nums = new long[count];

        nums[0] = x % 10;

        for (int i = 1, j = 10; i < count; i++, j *= 10)
        {
            nums[i] = (x / j) % 10;
        }

        for (int i = 0, j = count - 1; i < count; i++, j--)
        {
            if (nums[i] != nums[j]) return false;
        }

        return true;
    }
}
