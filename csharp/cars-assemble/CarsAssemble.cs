using System;

static class AssemblyLine
{
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SucessRateBasedOnSpeed(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }

    public static double SucessRateBasedOnSpeed(int speed) =>
        speed switch
        {
            <= 4 => 1.0,
            <= 8 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => throw new ArgumentOutOfRangeException("Speed value is not valid")
        };
}
