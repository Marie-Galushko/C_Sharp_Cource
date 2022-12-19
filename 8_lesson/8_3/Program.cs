// Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void SwapFirstLastString(int[,] matrix)
{
    int minValue = matrix[0, 0], minRow = 0, minColumn = 0;
// заводим переменные для нахождения минимума в двумерном массиве
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue)// если встретилось такое число, которое меньше нашего минимального значения, то делаем замены
            {
                minValue = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
            // таким образом нашли первый максимум
        }
    }
    Console.WriteLine($"Минимум {minValue} на позиции({minRow + 1}, {minColumn + 1})");
    Console.WriteLine();
    Console.WriteLine("Конечный массив");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != minRow && j != minColumn)// игнорируем те элементы, которые имеют ту же строку и тот же столбец
                Console.Write($"{matrix[i, j]} \t");
        }
        if (i != minRow)
            Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив");
InputMatrix(matrix);
SwapFirstLastString(matrix);