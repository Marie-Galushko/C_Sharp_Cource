// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// Без модуля Math, используем цикл for.

Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Math.Abs(Convert.ToInt32(Console.ReadLine())); // вводим модуль, иначе минусовая степень приведет нас к вещественным числам, а не int
int result = A;
for (int i = 1; i < B; i++)
{
result = result * A;
}
Console.WriteLine($"{A} в степени {B} равно: " + result);