// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите через пробел все элементы: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x=> x > 0);
Console.WriteLine($"Кол-во элементов больше нуля: {count}");

// 2 вариант

// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 0;
// for (int i = 0; i < n; i++)
// {
//     int x = Convert.ToInt32(Console.ReadLine());
//     if (x > 0)
//         count++;
// }
// Console.WriteLine(count);

// 3 вариант

// Console.Clear();
// int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int count = 0;
// foreach (int element in numbers)
// {
//     if (element > 0)
//         count++;
// }
// Console.WriteLine(count);


