С рекурсией

int rec(int a, int b)
{
    if (a == 0)
        return b;
    return rec(a - 1, b + 1);
}


Console.Clear();
Console.Write("Введите числа: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine(rec(numbers[0], numbers[1]));


// с while 

// Console.Clear();
// Console.Write("Введите числа: ");
// int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int a = numbers[0], b = numbers[1];
// while (a != 0)
// {
//     a--;
//     b++;
// }
// Console.WriteLine(b);