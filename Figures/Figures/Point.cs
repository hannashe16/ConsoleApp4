namespace Figures
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        /*public Point GetVectorCoordinates(Point point1, Point point2)
        { 
           Point vector12 = new Point(point1.X - point2.X, point1.Y - point2.Y);
           return vector12;
        }*/
    }
}
