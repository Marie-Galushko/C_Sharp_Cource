// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

// Вариант 1

Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine((1 + n) / 2 * n); // формула арифметической прогрессии


// Вариант 2

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), sum = 0;
for (int i = 1; i <= n; i++)
    sum = sum + i;
Console.WriteLine($"Результат: {sum}");