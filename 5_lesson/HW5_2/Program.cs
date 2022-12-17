// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100);
}

void ReleaseArray(int[] array) 

{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++) 
    {   
        if(i % 2 == 0)
            Sum += array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {Sum}");
    
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array); 
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
ReleaseArray(array); 
