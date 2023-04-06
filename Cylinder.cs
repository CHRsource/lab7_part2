#pragma warning disable
class Cylinder : Point2D
{
    protected Point2D o, a;
    protected double h;
    public Point2D O { get; }
    public Point2D A { get; }
    public double H { get; }
    public Cylinder(Point2D o, Point2D a, double h)
    {
        this.o = o;
        this.a = a;
        this.h = h;
    }
    public Cylinder(Point2D a, double h) : this(new Point2D(), a, h) { }
    public Cylinder(Point2D o, Point2D a) : this(o, a, 1) { }
    public Cylinder(double h) : this(new Point2D(), new Point2D(1, 1), h) { }
    public Cylinder() : this(1.0) { }
    public override void Input()
    {
        Console.WriteLine("Центр окружности в основании цилиндра.");
        o.Input();
        Console.WriteLine("Точка окружности в основании.");
        a.Input();
        Console.Write("Введите высоту: ");
        h = double.Parse(Console.ReadLine());
    }
    public override void Print()
    {
        Console.WriteLine("Цилиндр\nКоордината центра окружности в основании: " + o.ToString());
        Console.WriteLine("Координата точки окружности в основании: " + a.ToString());
        Console.WriteLine("Высота: " + h);
    }
    protected double Radius() { return o.Distance(a); }
    public virtual double BaseArea()
    {
        return Math.Round(Math.PI * Radius() * Radius(), 3);
    }
    public virtual double BasePerimeter()
    {
        return Math.Round(2 * Math.PI * Radius(), 3);
    }
    public double Volume()
    {
        return Math.Round(BaseArea() * h, 3);
    }
    public double SideSurfaceArea()
    {
        return Math.Round(BasePerimeter() * h, 3);
    }
}
