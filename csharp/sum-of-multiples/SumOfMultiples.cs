using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> numbersForSum = new List<int>();

        for (int i = 1; i < max; i++)
        {
            multiples.ToList().ForEach(m =>
            {
                if (m != 0 && i % m == 0 && !numbersForSum.Any(number => number == i))
                    numbersForSum.Add(i);
            });
        }

        return numbersForSum.Sum(); ;
    }
}
