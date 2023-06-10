using System;

class Program
{
    static double CalculateTrianglePerimeter(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Довжина сторони трикутника повинна бути додатнім числом.");
        }

        double perimeter = a + b + c;
        return perimeter;
    }

    static void Main(string[] args)
    {
        try
        {
            double sideA = 5;
            double sideB = 4;
            double sideC = 3;

            double perimeter = CalculateTrianglePerimeter(sideA, sideB, sideC);

            Console.WriteLine("Периметр трикутника: " + perimeter);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }

        Console.ReadLine();
    }
}
