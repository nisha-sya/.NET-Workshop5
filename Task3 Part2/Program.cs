namespace Task3_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            p.Print("Hello");
            p.Print(123);
            p.Print("Repeat", 3);
        }
    }
}
