namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car() { Brand = "Toyota", Speed = 120, Seats = 5 };
            Motorcycle m = new Motorcycle() { Brand = "Honda", Speed = 90, Type = "Sports" };

            c.Start();
            c.DisplayInfo();
            c.Stop();

            m.Start();
            m.DisplayInfo();
            m.Stop();

        }
    }
}
