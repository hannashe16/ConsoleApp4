using System;

namespace Figures
{
    internal class Triangle
    {
        public static Point Apex1 { get; set; }
        public static Point Apex2 { get; set; }
        public static Point Apex3 { get; set; }

        public Triangle (Point apex1, Point apex2, Point apex3)
        {
            Apex1 = apex1;
            Apex2 = apex2;
            Apex3 = apex3;
        }

        public static double GetTriangleArea(Point apex1, Point apex2, Point apex3)
        {
            /*Point vector12 = new Point(apex1.X - apex2.X, apex1.Y - apex2.Y);
            Point vector13 = new Point(apex1.X - apex3.X, apex1.Y - apex3.Y);*/

            double sideApex12 = 0, sideApex23 = 0, sideApex13 = 0, triangleArea = 0;
            sideApex12 = Math.Sqrt(Math.Pow((apex2.X - apex1.X), 2) + Math.Pow((apex2.Y - apex1.Y), 2));
            sideApex23 = Math.Sqrt(Math.Pow((apex2.X - apex3.X), 2) + Math.Pow((apex2.Y - apex3.Y), 2));
            sideApex13 = Math.Sqrt(Math.Pow((apex1.X - apex3.X), 2) + Math.Pow((apex1.Y - apex3.Y), 2));

            double halfPerimeter = (sideApex12 + sideApex23 + sideApex13) / 2;
            triangleArea =
                Math.Sqrt(halfPerimeter * (halfPerimeter - sideApex12) * (halfPerimeter - sideApex23) * (halfPerimeter - sideApex13));

            return triangleArea;
        }  
    }
}
