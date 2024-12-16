using System;

namespace lab1q6
{
    interface ILength
    {
        double Length { get; set; }
    }

    interface IWidth
    {
        double Width { get; set; }
    }

    class Rectangle : ILength, IWidth
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;
        }
    }

    class q6
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 5;
            rectangle.Width = 3;
            Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());
            Console.ReadKey();
        }
    }
}