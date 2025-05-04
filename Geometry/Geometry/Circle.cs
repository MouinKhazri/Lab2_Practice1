namespace Geometry;

public class Circle
{
    public double Radius { get; }
    public Point? Center { get; }

    // Constructor with center and radius
    public Circle(double radius, Point center)
    {
        Radius = radius;
        Center = center;
    }

    // Constructor with radius only
    public Circle(double radius)
    {
        Radius = radius;
        Center = null;  // No center provided
    }

    // Area of the circle
    public double Area
    {
        get
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Checks if a point belongs to the circle
    public bool? BelongsToCircle(Point point)
    {
        if (Center == null)
            return null;

        var dx = point.X - Center.X;
        var dy = point.Y - Center.Y;
        var distance = Math.Sqrt(dx * dx + dy * dy);

        return distance == Radius;
    }
}
