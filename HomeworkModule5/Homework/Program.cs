namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanNumeral.Parse("XXC"));
            Calculator calc = new Calculator();
            calc.CalcTriangleSquare(14.4, 15, 30);
        }
    }
} 

