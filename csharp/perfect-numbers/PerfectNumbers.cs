using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (GetDivisors(number).Sum() == number)
            return Classification.Perfect;

        if (GetDivisors(number).Sum() > number)
            return Classification.Abundant;

        return Classification.Deficient;
    }

    public static List<int> GetDivisors(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentOutOfRangeException("Number must be positive and greater than zero");
        }
        List<int> divisors = new List<int>();
        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0 && n != i)
            {
                divisors.Add(i);
                if (i != n / i)
                {
                    divisors.Add(n / i);
                }
            }
        }
        divisors.Remove(divisors.SingleOrDefault(d => d == n));
        divisors.Sort();
        return divisors;
    }
}
