using System;

namespace Figures
{
    internal class Circle
    {
        public static Point CircleCenter { get; set; }
        public static Point CirclePoint { get; set; }

        public Circle(Point circleCenter, Point circlePoint)
        {
            CircleCenter = CircleCenter;
            CirclePoint = circlePoint;
        }

        public static double GetCircleArea(Point circleCenter, Point circlePoint)
        {
            double radius = 0, circleArea = 0;
            radius = Math.Sqrt(Math.Pow((circlePoint.X - circleCenter.X), 2) + Math.Pow((circleCenter.Y - circlePoint.Y), 2));
            circleArea = Math.PI * Math.Pow(radius, 2);
            return circleArea;
        }
    }
}
