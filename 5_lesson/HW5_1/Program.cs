// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}

void ReleaseArray(int[] array) 

{
    int SumPos = 0;
    for (int i = 0; i < array.Length; i++) 
    {   
        if(array[i] % 2 == 0)
            SumPos++;
    }
    Console.WriteLine($"Количество четных чисел равно {SumPos}");
    
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array); 
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
ReleaseArray(array); 