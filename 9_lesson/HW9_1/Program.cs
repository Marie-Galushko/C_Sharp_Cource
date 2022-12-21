// Задайте значение N. Напишите программу, которая выведет 
// все четные натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void EvenNum(int a)
{
    if(a == 0) return;
    if(a%2 == 0)
    EvenNum(a-2);
    else
    EvenNum(a-1);
    if(a%2 == 0)
    Console.Write($" {a} ");

}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
EvenNum(n);