// 3. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива,значения которых лежат в отрезке [10,99].

void InputArray(int[] array) //InputArray - процедура для заполнения нашего массива, внутри процедуры передаем сам наш массив array
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101);
}

int ReleaseArray(int[] array) // процедура решения задачи

{   
    int count = 0;
    for (int i = 0; i < array.Length; i++) // проходимся по каждому эл
    {
        if ( array[i] >= 10 && array[i] <= 99)
            count++; // count = count + 1
    }    
    return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int[] array = new int[123]; // завели массив из 123 эл
InputArray(array); // вызвали процедуру заполнения массива
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); // вывод начального массива на экран
Console.WriteLine(ReleaseArray(array)); // вывод процедуры решения на экран



// ?? Console.Write("Введите кол-во элементов массива: ");



// 2 вариант

// void Print(int[] arr)
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//         Console.Write($"{arr[i]} ");
//     Console.WriteLine();
// }

// int[] ArrayNums(int size, int start, int last)
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//         arr[i] = new Random().Next(start, last + 1);
//     return arr;
// }

// int CountDiap(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 10 && arr[i] <= 99)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] arr_1 = ArrayNums(int.Parse(Console.ReadLine()),
//                         int.Parse(Console.ReadLine()),
//                         int.Parse(Console.ReadLine()));
// Print(arr_1);
// Console.Write(CountDiap(arr_1));