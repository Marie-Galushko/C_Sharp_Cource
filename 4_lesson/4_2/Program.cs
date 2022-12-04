// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
while (n / 10 != 0)
{
    n /= 10; // n = n/10
    count++; // count = count + 1
}
Console.WriteLine(count);
