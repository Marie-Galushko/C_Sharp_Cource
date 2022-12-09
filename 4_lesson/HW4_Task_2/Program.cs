// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int i = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int summa = 0;
while (i > 0)
{
    int number = i % 10;
    i = i / 10;
    summa = summa + number;
    if (i < 1) 
    {
        i = 0;
    }
}
Console.WriteLine("Сумма всех цифр числа: " + summa);
