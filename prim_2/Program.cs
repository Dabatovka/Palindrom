// Написать программу, которая принимает на вход координаты двух
// точек и находит расстояние между нима в 3D пространстве. 

Console.WriteLine("Введите X1: ");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Z1");
double Z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите X2: ");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Z2");
double Z2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(X1 - X2, 2))+ Math.Pow(Y1 - Y2, 2)+ Math.Pow(Z1-Z2, 2);

Console.WriteLine($"d={d:f2}");

