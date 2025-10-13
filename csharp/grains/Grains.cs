using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException("Number must be positive");
        }

        return 1UL << (n - 1);
    }

    public static ulong Total()
    {
        return ulong.MaxValue;
    }
}
