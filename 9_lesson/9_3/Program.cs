// Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.

string rec(int n, int m)
{
    if (n == m)
        return $"{n} ";
    return rec(n, m - 1) + $"{m} ";
}


Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n, m));

