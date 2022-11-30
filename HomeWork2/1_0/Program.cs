// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(SecondDigit(n));

int SecondDigit (int num)
{
    return (num / 10) % 10;
}

