namespace Figures
{
    internal class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public static double GetRectangleArea(Point rectangleTopLeft, Point rectangleBottomRight)
        {
            double rectangleLengh = 0, rectangleWidth = 0, rectangleArea = 0;
            rectangleLengh = rectangleBottomRight.X - rectangleTopLeft.X;
            rectangleWidth = rectangleTopLeft.Y - rectangleBottomRight.Y;
            rectangleArea = rectangleLengh * rectangleWidth;
            return rectangleArea;
        }
    }
}
