using System;
using System.Linq;
using System.Collections.Generic;

public class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span == 0 || (span == 0 && String.IsNullOrEmpty(digits)))
            return 1;
        if (String.IsNullOrWhiteSpace(digits) || digits.Any(c => char.IsLetter(c)) || span < 0 || span > digits.Length)
            throw new ArgumentException();

        double[] digitsArray = Array.ConvertAll(digits.ToArray(), s => char.GetNumericValue(s));
        double product = 0;
        for (int i = 0; i <= digitsArray.Length - span; i++)
        {
            double aux = digitsArray[i];
            for (int j = 1; j <= span - 1; j++)
            {
                aux *= digitsArray[i + j];
            }
            if (product < aux)
                product = aux;
        }
        return (long)product;
    }
}
