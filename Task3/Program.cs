namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher nep = new NepaliTeacher();
            nep.Teaching();
            nep.SalaryInfo();

            Teacher eng = new EnglishTeacher();
            eng.Teaching();
            eng.SalaryInfo();

        }
    }
}
