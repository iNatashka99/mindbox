using System;
using Shapes;


namespace MindBoxCase
{

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2);
            Triangle triangle1 = new Triangle(2, 2, 3);
            Triangle triangle2 = new Triangle(3, 5, 4);
            Console.WriteLine($"A circle square is {circle.Square()}.");
            Console.WriteLine($"A triangle1 square is {triangle1.Square()}.");
            Console.WriteLine($"A triangle2 square is {triangle2.Square()}.");
            Console.WriteLine($"A triangle1 is{(triangle1.isRight() ? " " : " not ")}right.");
            Console.WriteLine($"A triangle2 is{(triangle2.isRight() ? " " : " not ")}right.");
            Console.ReadKey(true);
        }
    }
}
