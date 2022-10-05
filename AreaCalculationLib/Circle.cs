namespace AreaCalculationLib
{
    public class Circle : Shape
    {
        private double _r;

        public double R { get => _r; set => _r = value; }

        public Circle(double r)
        {
            R = r;
        }

        public override double GetArea()
        {
            return PI * R * R;
        }
    }
}
