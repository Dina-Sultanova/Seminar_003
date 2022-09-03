// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки");
Console.WriteLine("X = ");
double XA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y = ");
double YA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.WriteLine("X = ");
double XB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y = ");
double YB = Convert.ToDouble(Console.ReadLine());

double resX = Math.Pow(XB - XA, 2);
double resY = Math.Pow(YB - YA, 2);
double res = Math.Sqrt(resX + resY);

Console.WriteLine($"Расстояние между двумя точками {res:f2}");
