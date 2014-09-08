using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PerimeterAreaPolygon
{
    static void Main(string[] args)
    {
        int numberOfPoints = int.Parse(Console.ReadLine());
        Polygon polygon = new Polygon();

        for (int i = 0; i < numberOfPoints; i++)
        {
            string[] coordinates = Console.ReadLine().Split(new char[] { ' ' });
            polygon.AddPoint(new Point(int.Parse(coordinates[0]), int.Parse(coordinates[1])));
        }

        polygon.PrintAreaAndPerimeter();
    }
}

struct Point
{
    private int x;
    private int y;

    public int X
    {
        get { return this.x; }
        set { this.x = value; }
    }
    public int Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    public Point(int xCoordinate, int yCoordinate)
    {
        this.x = xCoordinate;
        this.y = yCoordinate;
    }
}

class Polygon
{
    private List<Point> points;

    public Polygon()
    {
        this.points = new List<Point>();
    }

    public void AddPoint(Point point)
    {
        this.points.Add(point);
    }

    private double CalculateArea()
    {
        int firstSum = 0;
        int secondSum = 0;

        for (int i = 0; i < points.Count; i++)
        {
            if (i == 0)
            {
                firstSum += points[i].X * points[i + 1].Y;
                secondSum += points[i].X * points[points.Count - 1].Y;
            }
            else if (i == points.Count - 1)
            {
                firstSum += points[i].X * points[0].Y;
                secondSum += points[i].X * points[i - 1].Y;
            }
            else
            {
                firstSum += points[i].X * points[i + 1].Y;
                secondSum += points[i].X * points[i - 1].Y;
            }
        }
        return (firstSum - secondSum) / 2.0;
    }

    private double CalculatePerimeter()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Count; i++)
        {
            if (i != points.Count - 1)
            {
                perimeter += Math.Sqrt(Math.Pow(points[i + 1].X - points[i].X, 2) + Math.Pow(points[i + 1].Y - points[i].Y, 2));
            }
            else
            {
                perimeter += Math.Sqrt(Math.Pow(points[0].X - points[i].X, 2) + Math.Pow(points[0].Y - points[i].Y, 2));
            }
        }
        return perimeter;
    }

    public void PrintAreaAndPerimeter()
    {
        Console.WriteLine("area -> {0:0.##}", this.CalculateArea());
        Console.WriteLine("perimeter -> {0:0.##}", this.CalculatePerimeter());
    }
}

