public class OfficePrinter : IPrintable, IScannable
{
    public void Print() => Console.WriteLine("OfficePrinter printing...");
    public void Scan() => Console.WriteLine("OfficePrinter scanning...");
}