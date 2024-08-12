using Geometry_visualization;

public class Triangulation
{
    public static List<Triangle> Triangulate(
        List<Point> polygon,
        double translateX = 0,
        double translateY = 0,
        double scaleX = 1,
        double scaleY = 1,
        double angle = 0)
    {
       
        //var transformedPolygon = Transform.Translate(polygon, translateX, translateY);
        //transformedPolygon = Transform.Scale(transformedPolygon, scaleX, scaleY);
        //transformedPolygon = Transform.Rotate(transformedPolygon, angle);

        var triangles = new List<Triangle>();
        var vertices = new List<Point>(polygon);

        while (vertices.Count > 3)
        {
            bool triangleFound = false;
            for (int i = 0; i < vertices.Count; i++)
            {
                int prev = (i - 1 + vertices.Count) % vertices.Count;
                int next = (i + 1) % vertices.Count;

                Point prevVertex = vertices[prev];
                Point currVertex = vertices[i];
                Point nextVertex = vertices[next];

                if (IsTriangle(prevVertex, currVertex, nextVertex, vertices))
                {
                    triangles.Add(new Triangle(prevVertex, currVertex, nextVertex));
                    vertices.RemoveAt(i);
                    triangleFound = true;
                    break;
                }
            }
        }

        if (vertices.Count == 3)
        {
            triangles.Add(new Triangle(vertices[0], vertices[1], vertices[2]));
        }

        return triangles;
    }

    private static bool IsTriangle(Point prev, Point curr, Point next, List<Point> vertices)
    {
        if (Area(prev, curr, next) <= 0)
            return false;

        foreach (var vertex in vertices)
        {
            if (IsPointInTriangle(vertex, prev, curr, next))
                return false;
        }

        return true;
    }

    private static bool IsPointInTriangle(Point p, Point a, Point b, Point c)
    {
        double areaABC = Area(a, b, c);

        double areaPAB = Area(p, a, b);
        double areaPBC = Area(p, b, c);
        double areaPCA = Area(p, c, a);

        return ((areaPAB + areaPBC + areaPCA) - areaABC) < 0;
    }

    private static double Area(Point a, Point b, Point c)
    {
        return 0.5 * ((b.X - a.X) * (c.Y - a.Y) - (c.X - a.X) * (b.Y - a.Y));
    }
}
