namespace Homework;

public class Calculator
{
    public void CalcTriangleSquare(double ab, double ac, int alpha)
    {
        double square;
        double rads = alpha * Math.PI / 180;
        square = ab * ac * Math.Sin(rads);
        Console.WriteLine(square);
    }
}