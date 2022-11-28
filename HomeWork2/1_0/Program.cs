// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine(Num(new Random().Next(100,1000)));

int Num(int num)
{
    Console.WriteLine(num);

    return num%100/10;
}