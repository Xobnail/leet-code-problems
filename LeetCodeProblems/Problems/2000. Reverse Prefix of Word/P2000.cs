namespace LeetCodeProblems.Problems._2000._Reverse_Prefix_of_Word;

/// <summary>
/// 2000. Reverse Prefix of Word
/// </summary>
internal class P2000
{
    public string ReversePrefix(string word, char ch)
    {
        char[] chars = word.ToCharArray();

        int fo = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == ch)
            {
                fo = i;
                break;
            }
        }

        for (int l = 0, r = fo; l < r; l++, r--)
        {
            var buf = chars[l];
            chars[l] = chars[r];
            chars[r] = buf;
        }

        return new string(chars);
    }
}
