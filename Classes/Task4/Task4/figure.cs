using System;
using System.Collections.Generic;

namespace Task4
{
    class figure
    {
        List<Point> points = new List<Point>();
        public string Name { get; set; }
        public figure(Point xPoint, Point yPoint, Point cPoint)
        {
            points.Add(xPoint);
            points.Add(yPoint);
            points.Add(cPoint);

        }

        public figure(Point xPoint, Point yPoint, Point cPoint, Point aPoint)
        {
            points.Add(xPoint);
            points.Add(yPoint);
            points.Add(cPoint);
            points.Add(aPoint);

        }

        public figure(Point xPoint, Point yPoint, Point cPoint, Point aPoint, Point bPoint)
        {
            points.Add(xPoint);
            points.Add(yPoint);
            points.Add(cPoint);
            points.Add(aPoint);
            points.Add(bPoint);

        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.GetX() - b.GetX(), 2) + Math.Pow(a.GetY() - b.GetY(), 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Count; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Count - 1]);
            return perimeter;
        }
    }
}
