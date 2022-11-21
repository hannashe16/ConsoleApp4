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

        public double GetRectangleArea()
        {
            double rectangleLengh = 0, rectangleWidth = 0, rectangleArea = 0;
            rectangleLengh = BottomRight.X - TopLeft.X;
            rectangleWidth = TopLeft.Y - BottomRight.Y;
            rectangleArea = rectangleLengh * rectangleWidth;
            return rectangleArea;
        }
    }
}
