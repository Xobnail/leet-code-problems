namespace LeetCodeProblems.Problems._832._Flipping_an_Image;

/// <summary>
/// 832. Flipping an Image
/// </summary>
internal class P832
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        int m = image.Length;
        int n = image[0].Length;

        for (int i = 0; i < m; i++)
            for (int jl = 0, jr = n - 1; jl < (n + 1) / 2; jl++, jr--)
                if (image[i][jl] == image[i][jr])
                    image[i][jl] = image[i][jr] ^= 1;

        return image;
    }

    //public int[][] FlipAndInvertImage(int[][] image)
    //{
    //    int m = image.Length;
    //    int n = image[0].Length;

    //    for (int i = 0; i < m; i++)
    //    {
    //        for (int jl = 0, jr = n - 1; jl < (n + 1) / 2; jl++, jr--)
    //        {
    //            int temp = image[i][jl];
    //            image[i][jl] = image[i][jr];
    //            image[i][jr] = temp;

    //            if (jl != jr)
    //            {
    //                image[i][jl] = image[i][jl] == 1 ? 0 : 1;
    //            }

    //            image[i][jr] = image[i][jr] == 1 ? 0 : 1;
    //        }
    //    }

    //    return image;
    //}
}
