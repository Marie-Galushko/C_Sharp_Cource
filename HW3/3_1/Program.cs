// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int chislo = int.Parse(Console.ReadLine());
Console.WriteLine(Polindrom(chislo));

string Polindrom(int N)
{
    int N2 = N;
    int num = 0;
    int reverse = 0;
    while (N > 0)
    {
        num = N % 10;
        reverse = reverse * 10 + num;
        N = N / 10;
    }
    if (N2 == reverse)
        return "Число является полиндромом";
    else
        return "Число не является полиндромом";
}

