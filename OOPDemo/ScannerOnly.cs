public class ScannerOnly : IScannable, IFaxable
{
    public void Scan() => Console.WriteLine("ScannerOnly scanning...");
    public void Fax() => Console.WriteLine("ScannerOnly faxing...");
}