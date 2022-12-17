// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2);
}


void DiffMaxMin(double[] array)
{
    double minArray = array[0], maxArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minArray)
            minArray = array[0];
        else if (array[i] > maxArray)
            maxArray = array[i];
    }
    Console.WriteLine($"Результат: {maxArray - minArray}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
DiffMaxMin(array);

// 2 вариант

// void Print(double[] arr_1)
// {
//     int num = arr_1.Length;

//     for (int i = 0; i < num; i++)
//         Console.Write($"{Math.Round(arr_1[i], 2)}  ");
    
//     Console.WriteLine();
// }

// double[] Massiv(int size, double begin, double end)
// {
//     double[] arr_1 = new double[size];

//     for (int i = 0; i < size; i++)
//     {
//         Random rnd = new Random();
//         arr_1[i] = rnd.NextDouble() * (end - begin) + begin;

//     }
//     return arr_1;
// }  

// double Raznost(double[] arr_1)
// {
//     double max = arr_1[0];
//     double min = arr_1[0];
    
//     for (int i = 1; i < arr_1.Length; i++)
//     {
//         if (arr_1[i] > max)
//             max = arr_1[i] ; 
//         if (arr_1[i] < min)
//             min = arr_1[i];
//     }
    
//     Console.WriteLine($"Max = {Math.Round(max,2)}  Min = {Math.Round(min,2)}");
//     return max - min;
// }

// double[] arr = Massiv(int.Parse(Console.ReadLine()),  
//                       double.Parse(Console.ReadLine()), 
//                       double.Parse(Console.ReadLine())); 
// Print(arr);
// Console.WriteLine($"Разница между максимальным и минимальным элементами равна {Math.Round(Raznost(arr),2)}");
