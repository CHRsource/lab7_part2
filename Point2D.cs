#pragma warning disable
using cs_lab7_part2;

class Point2D : ICLIable
{
    public double X { get; set; }
    public double Y { get; set; }
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }
    public Point2D() : this(0, 0) { }
    public Point2D(double x) : this(x, x) { }
    public virtual void Input()
    {
        Console.Write("Введите координаты.\nx = ");
        X = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        Y = double.Parse(Console.ReadLine());
    }
    public virtual void Print()
    {
        Console.WriteLine("Точка " + ToString());
    }
    public override string ToString()
    {
        return $"({Math.Round(X, 3)}, {Math.Round(Y, 3)})";
    }
    public double Distance(Point2D obj) { return Math.Round(Math.Sqrt((X - obj.X) * (X - obj.X) + (Y - obj.Y) * (Y - obj.Y)), 3); }

}