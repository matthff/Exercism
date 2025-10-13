using System;
using System.Linq;
using System.Collections.Generic;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        double sum = 0;
        number.ToString().ToList().ForEach(c => { sum += Math.Pow(int.Parse(c.ToString()), (int)number.ToString().Length); });
        return sum == number;
    }
}
