// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет

// 1 вариант

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(ThirdDigit(number));

string ThirdDigit(int num)
{
        if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }   
        return $"{num % 10} ";
    }
    else
        return "Данное число меньше трехзначного, третья цифра в нем отсутствует";
}

// 2 вариант

// ДЗ 2. task 13

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.WriteLine("3-ей цифры нет");
else
{
    while (n > 1000)
        n = n / 10;
    
    Console.WriteLine(n);
    Console.WriteLine(n % 10);
}