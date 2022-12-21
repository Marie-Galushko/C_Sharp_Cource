// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

string rec(int n)
{
    if (n == 1)
        return "1 ";
    return rec(n - 1) + $"{n} ";
}


Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));

// 2 вариант без рекурсии

// void rec(int n)
// {
//     if (n == 1)
//         Console.Write("1 ");
//     else if (n > 1)
//     {
//         Console.Write($"{n} ");
//         rec(n - 1);
//     }
// }


// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// rec(n);