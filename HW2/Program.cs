using static System.Math;
int x1, x2, y1, y2, z1, z2;
Console.WriteLine("Введите координаты точки А (x1,y1,z1)");
Console.Write("x1 = ");
x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2 = ");
x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 = ");
z2 = Convert.ToInt32(Console.ReadLine());
double d = Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.Write("Среднее расстояние между двумя точками равно = ");
Console.WriteLine(d);