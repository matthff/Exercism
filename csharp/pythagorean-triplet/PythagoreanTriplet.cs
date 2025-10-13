using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        var solutions = new List<(int a, int b, int c)>();
        for (int i = 1; i < sum; i++)
        {
            int denom = 2 * (sum - i);
            int num = (int)(2 * Math.Pow(i, 2) + Math.Pow(sum, 2) - 2 * sum * i);
            if (denom > 0 && num % denom == 0)
            {
                int c = num / denom;
                int b = sum - i - c;
                if (b > i)
                {
                    solutions.Add((i, b, c));
                }
            }
        }
        return solutions;
    }
}
