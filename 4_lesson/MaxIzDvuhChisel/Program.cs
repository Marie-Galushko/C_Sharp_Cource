// function
// Найти максимум из 2-х чисел

int numbersMax(int n, int m)
{
    if (n > m)
        return n; // return обрывает необходимость дальнейшей проверки
    return m;
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numbersMax(n, m));
