// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке. 
// Например:[1,0,1,1,0,1,0,0]

Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 2);
Console.WriteLine($"[{string.Join(", ", array)}]");

// !!! Основной код для ввода n элементов массива в рандоме
// 2 вариант Марии

void Massiv(int n)
	{
	    int[] array = new int[n];
	    for (int i = 0; i < n; i++)
	    {
	        array[i] = new Random().Next(2);
	        Console.Write($"{array[i]}, ");
	    }   
	}
	
	Console.WriteLine("Введите число элементов массива");
	Massiv(int.Parse(Console.ReadLine()));
