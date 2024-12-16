using System;

namespace lab1q7
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape.");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle.");
        }
    }

    class q7
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle();
            Shape shape2 = new Square();
            Shape shape3 = new Triangle();

            shape1.Draw();
            shape2.Draw();
            shape3.Draw();

            Console.ReadKey();
        }
    }
}