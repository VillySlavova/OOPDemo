public class Laptop : Computer
{
    public override string OS => "Windows 11";

    public override void Start()
    {
        Console.WriteLine("Laptop is starting...");
    }
}