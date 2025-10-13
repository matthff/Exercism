using System;

class RemoteControlCar
{
    private double _batteriesPercentage = 100;
    private double _metersTraveled = 0;

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_metersTraveled} meters";

    public string BatteryDisplay() => _batteriesPercentage == 0 ? "Battery empty" : $"Battery at {_batteriesPercentage}%";

    public void Drive()
    {
        if (_batteriesPercentage > 0)
        {
            _batteriesPercentage -= 1;
            _metersTraveled += 20;
        }
    }
}
