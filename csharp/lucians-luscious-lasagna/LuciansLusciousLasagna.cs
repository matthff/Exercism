class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minutesInOven) => 40 - minutesInOven;

    public int PreparationTimeInMinutes(int layers) => 2 * layers;

    public int ElapsedTimeInMinutes(int layers, int minutesInOven) => minutesInOven + PreparationTimeInMinutes(layers);
}
