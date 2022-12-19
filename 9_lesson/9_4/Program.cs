// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.

int rec(int a)
{
    if (a / 10 == 0 || a < 10 || a % 10 == a)
        return a;
    return rec(a / 10) + a % 10;
}


Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));
