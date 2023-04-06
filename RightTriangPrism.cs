#pragma warning disable
class RightTriangPrism : Cylinder
{
    protected Point2D b;
    public Point2D B { get; }
    public RightTriangPrism(Point2D o, Point2D a, Point2D b, double h) : base(o, a, h)
    {
        this.b = b;
    }
    public RightTriangPrism(Point2D o, Point2D a, Point2D b) : this(o, a, b, 1) { }
    public RightTriangPrism(double h) : this(new Point2D(), new Point2D(0, 1), new Point2D(1, 0), h) { }
    public RightTriangPrism() : this(1.0) { }
    public override void Input()
    {
        Console.WriteLine("1-ая точка основания призмы.");
        o.Input();
        Console.WriteLine("2-ая точка основания призмы.");
        a.Input();
        Console.WriteLine("3-я точка основания призмы.");
        b.Input();
        Console.Write("Введите длину боковой стороны: ");
        h = double.Parse(Console.ReadLine());
    }
    public override void Print()
    {
        Console.WriteLine("Прямая треугольная призма\nКоординаты 1-ой точки основания: " + o.ToString());
        Console.WriteLine("Координаты 2-ой точки основания: " + a.ToString());
        Console.WriteLine("Координаты 3-ей точки основания: " + b.ToString());
        Console.WriteLine("Длина боковой стороны: " + h);
    }
    public override double BaseArea() { return TriangleArea(o, a, b); }
    public override double BasePerimeter()
    {
        return Math.Round(o.Distance(a) + a.Distance(b) + b.Distance(o), 3);
    }
    protected double TriangleArea(Point2D k, Point2D l, Point2D m)
    {
        double a1, a2, a3, p;
        a1 = k.Distance(l);
        a2 = l.Distance(m);
        a3 = m.Distance(k);
        p = (a1 + a2 + a3) / 2;
        return Math.Round(Math.Sqrt(p * (p - a1) * (p - a2) * (p - a3)), 3);
    }
}
