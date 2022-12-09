// 4. Найдите произведение пар чисел в одномерном массиве.
//    Парой считаем первый и последний элемент, второй и предпоследний
//    и т.д. Результат запишите в новом массиве.

void InputArray(int[] array) //InputArray - процедура для заполнения нашего массива, внутри процедуры передаем сам наш массив array
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-1, 11);
}

void ReleaseArray(int[] array) // процедура решения задачи

{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++) // проходимся по каждому эл
        Console.Write($"{array[i] * array[array.Length - i - 1]} ");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
// спросили у пользователя, завели массив
InputArray(array); // вызвали процедуру заполнения массива
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); // вывод начального массива на экран
ReleaseArray(array); // вызвали процедуру решения задачи

// 2 вариант

// void Print(int[] arr)
// 	{
// 	    int size = arr.Length;
	
// 	    for (int i = 0; i < size; i++)
// 	        Console.Write($"{arr[i]} ");
// 	    Console.WriteLine();
// 	}
	
// 	int[] MassNums(int size)
// 	{
// 	    int[] arr = new int[size];
	
// 	    for (int i = 0; i < size; i++)
// 	        arr[i] = new Random().Next(1, 11);
// 	    return arr;
// 	}
	
// 	int[] PairsNum(int[] arr)
// 	{
// 	    int size = arr.Length;
// 	    int flex_size = size / 2 + size % 2;
// 	    int[] new_arr = new int[flex_size];
	
// 	    for (int i = 0; i < size / 2; i++)
// 	        new_arr[i] = arr[i] * arr[size - i - 1];
	
// 	    if (new_arr[flex_size - 1] == 0)
// 	        new_arr[flex_size - 1] = arr[flex_size - 1];
// 	    return new_arr;
// 	}
	
// 	int[] arr_1 = MassNums(5);
// 	Print(arr_1);
// 	int[] arr_1_new = PairsNum(arr_1);
// 	Print(arr_1_new);