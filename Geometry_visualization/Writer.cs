using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_visualization
{
    public class Writer
    {

        public static void WriteTriangles(List<Triangle> triangles)
        {
        string outputFilePath = @"E:\\CAGD_Training\\week_1\\Geometry_visualization\\output\\polygon.txt";
            using (var writer = new StreamWriter(outputFilePath))
            {
                foreach (var triangle in triangles)
                {
                    writer.WriteLine($"{triangle.A.X} {triangle.A.Y}");
                    writer.WriteLine($"{triangle.B.X} {triangle.B.Y}");
                    writer.WriteLine($"{triangle.C.X} {triangle.C.Y}");
                    writer.WriteLine($"{triangle.A.X} {triangle.A.Y}");
                    writer.WriteLine();
                }
            }

            Console.WriteLine($"Triangulation complete. Triangles written to {outputFilePath}");
        }
    }
}
