// Задача 20
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.WriteLine("X = ");
double XA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y = ");
double YA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Z = ");
double ZA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.WriteLine("X = ");
double XB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y = ");
double YB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Z = ");
double ZB = Convert.ToDouble(Console.ReadLine());

double resX = Math.Pow(XB - XA, 2);
double resY = Math.Pow(YB - YA, 2);
double resZ = Math.Pow(ZB - ZA, 2);
double res = Math.Sqrt(resX + resY + resZ);

Console.WriteLine($"Расстояние между двумя точками {res:f2}");
