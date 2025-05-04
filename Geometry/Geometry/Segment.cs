namespace Geometry;


public class Segment
{
    public Point A { get; }
    public Point B { get; }

    public Segment(Point a, Point b)
    {
        A = a;
        B = b;
    }

    public double Length
    {
        get
        {
            var dx = B.X - A.X;
            var dy = B.Y - A.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }

    public bool IsHorizontal => A.Y == B.Y;
    public bool IsVertical => A.X == B.X;

    public override bool Equals(object? obj)
    {
        if (obj is not Segment other)
            return false;

        return A.Equals(other.A) && B.Equals(other.B);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(A, B);
    }
}
