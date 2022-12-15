// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Amn = m + n.
// Выведите полученный массив на экран

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j; // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
//принимает строку, создает массив, где каждый элемент это строка.
// мы берем и проходимся функцией Select по каждому элементу массива строк, 
// переводим элемент в число и возвращаем массив обратно
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
