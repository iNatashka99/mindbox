using System;


namespace Shapes
{
    public class Triangle : Shape
    {
        private readonly double side1, side2, side3;

        public Triangle()
        {
            side1 = side2 = side3 = 1;
        }

        public Triangle(double side1, double side2, double side3)
        {
            if (double.IsInfinity(side1) || double.IsNaN(side1) || (side1 <= 0))
            {
                throw new ArgumentOutOfRangeException(nameof(side1), "Need a positive number");
            }
            if (double.IsInfinity(side2) || double.IsNaN(side2) || (side2 <= 0))
            {
                throw new ArgumentOutOfRangeException(nameof(side2), "Need a positive number");
            }
            if (double.IsInfinity(side3) || double.IsNaN(side3) || (side3 <= 0))
            {
                throw new ArgumentOutOfRangeException(nameof(side3), "Need a positive number");
            }
            if ((side1 + side2 <= side3) || (side2 + side3 <= side1) || (side3 + side1 <= side2))
            {
                throw new ArgumentException($"A triangle with sides {side1},{side2},{side3} does not exist!");
            }
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double Square()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public bool isRight()
        {
            double a = side1, b = side2, c = side3;
            double buf;
            if (c < a)
            {
                buf = a;
                a = c;
                c = buf;
            }
            if (c < b)
            {
                buf = b;
                b = c;
                c = buf;
            }
            return Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
        }
    }
}
