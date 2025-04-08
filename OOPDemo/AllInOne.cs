public class AllInOne : IPrintable, IScannable, IFaxable
{
    public void Print() => Console.WriteLine("AllInOne printing...");
    public void Scan() => Console.WriteLine("AllInOne scanning...");
    public void Fax() => Console.WriteLine("AllInOne faxing...");
}