using System;

namespace Figures
{
    internal class Circle
    {
        public Point CircleCenter { get; set; }
        public Point CirclePoint { get; set; }

        public Circle(Point circleCenter, Point circlePoint)
        {
            CircleCenter = CircleCenter;
            CirclePoint = circlePoint;
        }

        public double GetCircleArea()
        {
            double radius = 0, circleArea = 0;
            radius = Math.Sqrt(Math.Pow((CirclePoint.X - CircleCenter.X), 2) + Math.Pow((CircleCenter.Y - CirclePoint.Y), 2));
            circleArea = Math.PI * Math.Pow(radius, 2);
            return circleArea;
        }
    }
}
