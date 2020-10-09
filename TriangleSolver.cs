using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleAssignment
{
    public class TriangleSolver
    {
        public static string Analyze(double x, double y, double z)
        {

            String triangle;
            if (x + y <= z || x + z <= y || y + z <= x)
            {
                triangle = "Triangle cannot be formed with the inputs provided";
                return triangle;
            }
            else
            {
                if (x == y && y == z)
                    triangle = "Equilateral Triangle";
                else if (x == y || y == z || z == x)
                    triangle = "Isoceles Triangle";
                else
                    triangle = "Scalene Triangle";
                return triangle;
            }


        }
    }
}
