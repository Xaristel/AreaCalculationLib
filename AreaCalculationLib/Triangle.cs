namespace AreaCalculationLib
{
    public class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;

        public double A { get => _a; set => _a = value; }
        public double B { get => _b; set => _b = value; }
        public double C { get => _c; set => _c = value; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            if (C * C == (A * A + B * B)) //Pythagorean theorem
            {
                return 0.5 * A * B;
            }
            else
            {
                double p = (A + B + C) / 2D; //semi-perimeter

                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
    }
}
