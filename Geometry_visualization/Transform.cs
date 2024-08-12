using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_visualization
{
    public static class Transform
    {
        public static List<Point> Translate(List<Point> points, double x, double y)
        {
            return points.Select(p => new Point(p.X + x, p.Y + y)).ToList();
        }

        public static List<Point> Scale(List<Point> points, double x, double y)
        {
            return points.Select(p => new Point(p.X * x, p.Y * y)).ToList();
        }

        public static List<Point> Rotate(List<Point> points, double angle)
        {
            double radians = angle * (Math.PI / 180.0);
            return points.Select(p =>
            {
                double newX = p.X * Math.Cos(radians) - p.Y * Math.Sin(radians);
                double newY = p.X * Math.Sin(radians) + p.Y * Math.Cos(radians);
                return new Point(newX, newY);
            }).ToList();
        }

    }
    }
