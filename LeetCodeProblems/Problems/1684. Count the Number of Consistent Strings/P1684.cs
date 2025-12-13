namespace LeetCodeProblems.Problems._1684._Count_the_Number_of_Consistent_Strings;

/// <summary>
/// 1684. Count the Number of Consistent Strings
/// </summary>
internal class P1684
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        HashSet<char> chars = new(allowed);

        int result = 0;

        foreach (string word in words)
        {
            bool consistent = true;

            foreach (char ch in word)
            {
                if (!chars.Contains(ch))
                {
                    consistent = false;
                    break;
                }
            }

            if (consistent)
            {
                result++;
            }
        }

        return result;
    }
}
