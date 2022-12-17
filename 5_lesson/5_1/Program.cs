//Напишите программу замены элементов массива: положительные элементы 
//замените на соответствующие отрицательные, и наоборот.

void InputArray(int[] array) //InputArray - процедура для заполнения нашего массива, внутри процедуры передаем сам наш массив array
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
}

void ReleaseArray(int[] array) // процедура решения задачи

{
    for (int i = 0; i < array.Length; i++) // проходимся по каждому эл
        array[i] *= (-1); // array[i] = array[i] * (-1)
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
// спросили у пользователя, завели массив
InputArray(array); // вызвали процедуру заполнения массива
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); // вывод начального массива на экран
ReleaseArray(array); // вызвали процедуру решения задачи
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]"); // вывод полученного массива на экран

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

// void Massiv(int[] arr_1)
// {
//     for (int i = 0;i < arr_1.Length; i++)
//         arr_1[i] = -arr_1[i];

// }

// int[] arr_1 = Mass(int.Parse(Console.ReadLine()));
// Print(arr_1);
// Massiv(arr_1);
// Print(arr_1);
