using System;

public class SpaceAge
{
    private double absoluteSecondsOfLife;
    private double earthYearInSeconds = 31557600;

    public SpaceAge(int seconds)
    {
        absoluteSecondsOfLife = seconds;
    }

    public double OnEarth() => absoluteSecondsOfLife / earthYearInSeconds;

    public double OnMercury() => CalculateAge(0.2408467);

    public double OnVenus() => CalculateAge(0.61519726);

    public double OnMars() => CalculateAge(1.8808158);

    public double OnJupiter() => CalculateAge(11.862615);

    public double OnSaturn() => CalculateAge(29.447498);

    public double OnUranus() => CalculateAge(84.016846);

    public double OnNeptune() => CalculateAge(164.79132);

    private double CalculateAge(double orbitPeriod) => OnEarth() / orbitPeriod;
}
