// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет

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

