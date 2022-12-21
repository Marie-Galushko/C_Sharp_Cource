// Рекурсия

// Дана последовательность чисел, завершающаяся числом 0. 
// Найдите сумму всех этих чисел, не используя цикл.

// **Входные данные**

// Вводится последовательность целых чисел, оканчивающаяся числом 0 
// (само число 0 в последовательность не входит, а служит как признак ее окончания).

// **Выходные данные**
// Выведите ответ на задачу.

int sum()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 0)
        return 0;
    return sum() + x;
}


Console.Clear();
Console.WriteLine(sum());

// без рекурсии

// void sum(int res)
// {
//     int x = Convert.ToInt32(Console.ReadLine());
//     if (x == 0)
//         Console.WriteLine(res);
//     else
//     {
//         res += x;
//         sum(res);
//     }
// }


// Console.Clear();
// int res = 0;
// sum(res);