//Point2D c = new(4);
//c.Print();
//Point2D a = new();
//a.Print();
//a.Input();
//a.Print();
//Point2D b = new(-3, 5);
//b.Print();
//Console.WriteLine("Расстояние между точками a и b = " + a.Distance(b));

Point2D a1 = new(1, -1);
Point2D a2 = new(4);
Point2D a3 = new(-3, 5);
Point2D a4 = new(-1, -2);

//Cylinder c1 = new(a1, a2, 5);
//c1.Print();
//Console.WriteLine("Площадь окружности в основании цилиндра = " + c1.BaseArea());
//Console.WriteLine("Длина окружности в основании = " + c1.BasePerimeter());
//Console.WriteLine("Объем цилиндра =  " + c1.Volume());
//Console.WriteLine("Площадь боковой поверхности = " + c1.SideSurfaceArea());
//Cylinder c2 = new(a2, 3);
//c2.Print();
//Cylinder c3 = new();
//c3.Print();
//c3.Input();
//c3.Print();


//RightTriangPrism t1 = new(a1, a2, a3, 5);
//t1.Print();
//Console.WriteLine("Площадь основания прямой треугольной призмы = " + t1.BaseArea());
//Console.WriteLine("Периметр треугольника в основании = " + t1.BasePerimeter());
//Console.WriteLine("Объем призмы =  " + t1.Volume());
//Console.WriteLine("Площадь боковой поверхности = " + t1.SideSurfaceArea());
//RightTriangPrism t2 = new(a1, a2, a3);
//t2.Print();
//RightTriangPrism t3 = new(4);
//t3.Print();
//RightTriangPrism t4 = new();
//t4.Print();
//t4.Input();
//t4.Print();

void Check(RightQuadrPrism obj)
{
    if (obj.IsParallelepiped()) Console.WriteLine("параллелепипед");
    else Console.WriteLine("не параллелепипед");
    if (obj.IsCuboid()) Console.WriteLine("прямоугольный параллелепипед");
    else Console.WriteLine("не прямоугольный параллелепипед");
    if (obj.IsCube()) Console.WriteLine("куб");
    else Console.WriteLine("не куб");
}

a1 = new();
a2 = new(6, 1);
a3 = new(6, 7);
a4 = new(0, 6);
RightQuadrPrism q1 = new(a1, a2, a3, a4, 6);
q1.Print();
Console.WriteLine("Площадь основания прямой четырехугольной призмы = " + q1.BaseArea());
Console.WriteLine("Периметр четырехугольника в основании = " + q1.BasePerimeter());
Console.WriteLine("Объем призмы =  " + q1.Volume());
Console.WriteLine("Площадь боковой поверхности = " + q1.SideSurfaceArea());
Check(q1);
RightQuadrPrism q2 = new(a1, a2, a3, a4);
q2.Print();
RightQuadrPrism q3 = new(3);
q3.Print();
RightQuadrPrism q4 = new();
q4.Print();
Check(q4);
q4.Input();
q4.Print();
Check(q4);
