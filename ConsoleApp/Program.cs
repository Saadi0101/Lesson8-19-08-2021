using System;

namespace ConsoleApp
{
    class Program
    {
        class Rectangle
        {
            public double side1;
            public double side2;

            public Rectangle ()
            {
                Console.WriteLine("Введиту длину 1 сторону прямоугольника: ");
                side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введиту длину 2 сторону прямоугольника: ");
                side2 = double.Parse(Console.ReadLine());
            }

            public double AreaCalculator()
            {
                return side1 * side2;
            }

            public double PerimeterCalculator()
            {
                return 2 * (side1 + side2);
            }

            public double Area { get; }

            public double Perimetr { get; }
        }
        
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine($"Площадь прямоугольника: {rectangle.AreaCalculator()}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.PerimeterCalculator()}");



        }
    }
}
