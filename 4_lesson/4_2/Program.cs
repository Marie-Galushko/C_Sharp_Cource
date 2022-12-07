// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1; // count - кол-во цифр в числе
while (n / 10 != 0)
{
    n /= 10; // n = n/10, отбрасываем посл. цифру числа
    count++; // count = count + 1, увеличиваем на единицу
}
Console.WriteLine(count);
