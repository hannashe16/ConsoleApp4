using System;

namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point rectangleTopLeft = new Point(2,4);
            Point rectangleBottomRight = new Point(6,1);
            double rectangleArea = Rectangle.GetRectangleArea(rectangleTopLeft, rectangleBottomRight);
            Console.WriteLine(rectangleArea);

            Point squareTopLeft = new Point(2, 4);
            Point squareBottomRight = new Point(5,1);
            double squareArea = Square.GetSquareArea(squareTopLeft, squareBottomRight);
            Console.WriteLine(squareArea);

            Point trianglePoint1 = new Point(2, 4);
            Point trianglePoint2 = new Point(4, 5);
            Point trianglePoint3 = new Point(1, 1);
            double triangleArea = Triangle.GetTriangleArea(trianglePoint1, trianglePoint2, trianglePoint3);
            Console.WriteLine(triangleArea);

            Point circleCenter = new Point(3, 3);
            Point circlePoint = new Point(3, 2);
            double circleArea = Circle.GetCircleArea(circleCenter, circlePoint);
            Console.WriteLine(circleArea);
        }
        

        
    }
}
