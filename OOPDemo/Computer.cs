public abstract class Computer : Machine
{
    public override string DeviceType => "Computer";
    public abstract string OS { get; }

    public void PrintOS()
    {
        Console.WriteLine($"Operating System: {OS}");
    }
}