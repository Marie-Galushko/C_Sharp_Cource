// Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
//чисел равна 29, сумма отрицательных равна -20.


void InputArray(int[] array) //InputArray - процедура для заполнения нашего массива, внутри процедуры передаем сам наш массив array
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
}

void ReleaseArray(int[] array) // процедура решения задачи

{
    int sumNegative = 0, sumPositive = 0;
    for (int i = 0; i < array.Length; i++) // проходимся по каждому эл массива
    {
        if (array[i] > 0)
            sumPositive += array[i]; // sumPositive = sumPositive + array[i]
        else
            sumNegative += array[i]; // sumNegative = sumNegative + array[i]
    }
    Console.WriteLine($"Сумма положительных чисел равна {sumPositive}"); // вывод на экран
    Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}"); // вывод на экран
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
// спросили у пользователя, завели массив
InputArray(array); // вызвали процедуру заполнения массива
Console.WriteLine($"[{string.Join(", ", array)}]"); // вывод массива на экран
ReleaseArray(array); // вызвали процедуру решения задачи


// 2 вариант

// void Print(int[] arr)
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//         Console.Write($"{arr[i]} ");
//     Console.WriteLine();
// }

// int[] MassNums(int size, int from, int to)
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//         arr[i] = new Random().Next(from, to);
//     return arr;
// }

// void SumPosNeg(int[] arr)
// {
//     int pos, neg;
//     pos = neg = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 0)
//             pos += arr[i];
//         else
//             neg += arr[i];
//     }
//     Console.WriteLine($"Positive: {pos}, negative: {neg}");

// }

// int[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
//                        int.Parse(Console.ReadLine()),
//                        int.Parse(Console.ReadLine()));
// Print(arr_1);
// SumPosNeg(arr_1);