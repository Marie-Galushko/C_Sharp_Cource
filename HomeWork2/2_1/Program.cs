// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random(). Next(100,1000);
Console.WriteLine($"Случайное число: {num}");
int n1 = num/100;
int n3 = num%10;
Console.WriteLine(n1*10+n3);