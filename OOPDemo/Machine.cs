public abstract class Machine : IDevice
{
    public abstract string DeviceType { get; }
    public abstract void Start();

    public void ShowInfo()
    {
        Console.WriteLine("Machine is active.");
    }
}