namespace Figures
{
    internal class Square
    {
        public static Point TopLeft { get; set; }
        public static Point BottomRight { get; set; }
        public Square(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public static double GetSquareArea(Point squareTopLeft, Point squareBottomRight)
        {
            double squareSide = 0, squareArea = 0;
            squareSide = squareBottomRight.X - squareTopLeft.X;
            squareArea = squareSide * squareSide;
            return squareArea;
        }
    }
}
