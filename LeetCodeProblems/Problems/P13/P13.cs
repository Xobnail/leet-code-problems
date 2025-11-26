namespace LeetCodeProblems.Problems.P13;

/// <summary>
/// 13. Roman to Integer
/// </summary>
internal class P13
{
    public int RomanToInt(string roman)
    {
        int result = 0;

        for (int i = 0; i < roman.Length; i++)
        {
            if (i == roman.Length - 1)
            {
                result += ValOf(roman[i]);
                continue;
            }

            if (ValOf(roman[i]) >= ValOf(roman[i + 1]))
            {
                result += ValOf(roman[i]);
            }
            else if (ValOf(roman[i]) < ValOf(roman[i + 1]))
            {
                result += ValOf(roman[i + 1]) - ValOf(roman[i]);
                i++;
            }
        }

        return result;
    }

    public int ValOf(char roman)
    {
        switch (roman)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                return 0;
        }
    }
}
