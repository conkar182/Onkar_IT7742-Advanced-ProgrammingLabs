using System;

public abstract class Vehicle
{
    public abstract void StartEngine();
    public void StopEngine()
    {
        Console.WriteLine("Engine stopped");
    }
}
