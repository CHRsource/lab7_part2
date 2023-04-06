#pragma warning disable
class RightQuadrPrism : RightTriangPrism
{
    protected Point2D c;
    public Point2D C { get; }
    public RightQuadrPrism(Point2D o, Point2D a, Point2D b, Point2D c, double h) : base(o, a, b, h)
    {
        this.c = c;
    }
    public RightQuadrPrism(Point2D o, Point2D a, Point2D b, Point2D c) : this(o, a, b, c, 1) { }
    public RightQuadrPrism(double h) : this(new Point2D(), new Point2D(0, 1), new Point2D(1, 1), new Point2D(1, 0), h) { }
    public RightQuadrPrism() : this(1) { }
    public override void Input()
    {
        base.Input();
        Console.WriteLine("4-ая точка основания призмы.");
        c.Input();
    }
    public override void Print()
    {
        Console.WriteLine("Прямая треугольная призма\nКоординаты 1-ой точки основания: " + o.ToString());
        Console.WriteLine("Координаты 2-ой точки основания: " + a.ToString());
        Console.WriteLine("Координаты 3-ей точки основания: " + b.ToString());
        Console.WriteLine("Координаты 4-ой точки основания: " + c.ToString());
        Console.WriteLine("Длина боковой стороны: " + h);
    }
    public override double BaseArea() { return QuadrAngleArea(o, a, b, c); }
    public override double BasePerimeter()
    {
        return Math.Round(o.Distance(a) + a.Distance(b) + b.Distance(c) + c.Distance(o), 3);
    }
    public bool IsParallelepiped()
    {
        if (o.Distance(a) == b.Distance(c) & a.Distance(b) == c.Distance(o))
            return true;
        return false;
    }
    public bool IsCuboid()          // прямоугольный параллелепипед
    {
        if (IsParallelepiped() & o.Distance(b) == a.Distance(c))
            return true;
        return false;
    }
    public bool IsCube()
    {
        if (IsCuboid() & o.Distance(a) == a.Distance(b) & a.Distance(b) == h)
            return true;
        return false;
    }
   protected double QuadrAngleArea(Point2D k, Point2D l, Point2D m, Point2D n)
    {
        return Math.Round(0.5 * ((k.X*l.Y + l.X*m.Y + m.X*n.Y + n.X*k.Y) - (k.Y*l.X + l.Y*m.X + m.Y*n.X + n.Y*k.X)), 3);
    }
}
