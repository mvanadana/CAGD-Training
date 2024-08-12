using System;
using System.Collections.Generic;
using System.IO;

namespace Geometry_visualization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of coordinates: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 3)
            {
                Console.WriteLine("A polygon must have at least 3 vertices.");
                return;
            }

            var points = new List<Point>(n);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter x coordinate of point {i + 1}: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write($"Enter y coordinate of point {i + 1}: ");
                double y = double.Parse(Console.ReadLine());

                points.Add(new Point(x, y));
            }

            Console.WriteLine("Do you want to apply any transformations? (1.Translate/2.Scale/3.Rotate/4.All three/5.None)");
            string choice = Console.ReadLine().ToLower();

            double translateX = 0;
            double translateY = 0;
            double scaleX = 1;
            double scaleY = 1;
            double angle = 0;

            switch (choice)
            {
                case "1":
                    Console.Write("Enter translation X: ");
                    translateX = double.Parse(Console.ReadLine());

                    Console.Write("Enter translation Y: ");
                    translateY = double.Parse(Console.ReadLine());
                    break;

                case "2":
                    Console.Write("Enter scaling X: ");
                    scaleX = double.Parse(Console.ReadLine());

                    Console.Write("Enter scaling Y: ");
                    scaleY = double.Parse(Console.ReadLine());
                    break;

                case "3":
                    Console.Write("Enter rotation angle (in degrees): ");
                    angle = double.Parse(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter translation X: ");
                    translateX = double.Parse(Console.ReadLine());

                    Console.Write("Enter translation Y: ");
                    translateY = double.Parse(Console.ReadLine());

                    Console.Write("Enter scaling X: ");
                    scaleX = double.Parse(Console.ReadLine());

                    Console.Write("Enter scaling Y: ");
                    scaleY = double.Parse(Console.ReadLine());

                    Console.Write("Enter rotation angle (in degrees): ");
                    angle = double.Parse(Console.ReadLine());
                    break;

                case "5":
                    break;

                default:
                    Console.WriteLine("Invalid choice. No transformations will be applied.");
                    break;
            }

          
            if (translateX != 0 || translateY != 0)
            {
                points = Transform.Translate(points, translateX, translateY);
            }

            if (scaleX != 1 || scaleY != 1)
            {
                points = Transform.Scale(points, scaleX, scaleY);
            }

            if (angle != 0)
            {
                points = Transform.Rotate(points, angle);
            }

            List<Triangle> triangles = Triangulation.Triangulate(points);

            Writer.WriteTriangles(triangles);
        }
    }
}
