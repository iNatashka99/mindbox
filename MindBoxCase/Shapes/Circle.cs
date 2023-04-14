using System;


namespace Shapes
{
    public class Circle : Shape
    {
        private readonly double radius;

        public Circle() { radius = 1; }

        public Circle(double radius)
        {
            if (double.IsInfinity(radius) || double.IsNaN(radius) || (radius <= 0))
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Need a positive number");
            }
            this.radius = radius;
        }

        public override double Square()
        {
            return 2 * Math.PI * Math.Pow(radius, 2);
        }
        
    }
}
