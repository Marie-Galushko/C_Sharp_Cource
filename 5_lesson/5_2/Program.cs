// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.

void InputArray(int[] array) //InputArray - процедура для заполнения нашего массива, внутри процедуры передаем сам наш массив array
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
}

string ReleaseArray(int[] array, int k) // ReleaseArray - не процедура, а функция, которая вводит строку, в конце тоже она Console.Writeline
{
    for (int i = 0; i < array.Length; i++) // проходимся по каждому эл
    {
        if (array[i] == k)
            return "yes";
    }
    return "no";
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
// спросили у пользователя, завели массив
InputArray(array); // вызвали процедуру заполнения массива
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); // вывод начального массива на экран
Console.Write("Введите число, которое нужно найти в массиве: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, k)); // вывод функции ReleaseArray на экран


// 2 вариант

// void Print(int[] arr)
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//         Console.Write($"{arr[i]} ");
//     Console.WriteLine();
// }

// int[] Mass(int size)
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//         arr[i] = new Random().Next(-100, 100);
//     return arr;
// }

// string Poisk(int[] arr, int num)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(num == arr[i])
//             return "Yes";
//     }
//     return "No";
// }

// int[] arr_1 = Mass(int.Parse(Console.ReadLine()));
// Print(arr_1);
// Console.WriteLine(Poisk(arr_1, int.Parse(Console.ReadLine())));
