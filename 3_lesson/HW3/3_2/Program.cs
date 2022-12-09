//Задача 21: Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между ними в 3D пространстве.


Console.WriteLine("Введите координаты точки А: ");
double Xa = Convert.ToDouble(Console.ReadLine());
double Ya = Convert.ToDouble(Console.ReadLine());
double Za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
double Xb = Convert.ToDouble(Console.ReadLine());
double Yb = Convert.ToDouble(Console.ReadLine());
double Zb = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(Xa - Xb, 2) + Math.Pow(Ya - Yb, 2) + Math.Pow(Za - Zb, 2));
Console.WriteLine($"Расстояние между точками в 3D пространстве: {result} ");
