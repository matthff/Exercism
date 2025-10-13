using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int counter = 0;

        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException("Number must be positive integer");
        }

        while (number != 1)
        {
            if (number % 2 == 0)
            {
                number /= 2;
            }
            else
            {
                number = number * 3 + 1;
            }
            counter++;
        }
        return counter;
    }
}
