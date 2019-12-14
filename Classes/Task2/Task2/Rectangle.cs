namespace Task2
{
    public class Rectangle
    {
        private double side1 = 0;
        private double side2 = 0;

        public double Area()
        {
            return this.AreaCalculator();
        }

        public double Perimetr()
        {
            return this.PerimeterCalculator();
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double AreaCalculator()
        {
            double res = this.side1 * this.side2;
            return res;
        }

        double PerimeterCalculator()
        {
            double res = (this.side1 + this.side2) * 2;
            return res;
        }
    }
}
