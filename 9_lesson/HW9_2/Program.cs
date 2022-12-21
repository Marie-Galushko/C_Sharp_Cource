// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int Summ(int m, int n)
{
    if (m > n) return 0;
    return Summ(m + 1, n) + m;
}

Console.WriteLine("Enter Numbers: ");
Console.WriteLine(Summ(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));