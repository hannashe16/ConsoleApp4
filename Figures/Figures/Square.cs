namespace Figures
{
    internal class Square
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Square(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public double GetSquareArea()
        {
            double squareSide = 0, squareArea = 0;
            squareSide = BottomRight.X - TopLeft.X;
            squareArea = squareSide * squareSide;
            return squareArea;
        }
    }
}
