// Задайте двумерный массив. Найдите элементы, у которых
// оба индекса нечётные, и замените эти элементы на их квадраты.

void InputMatrix(int[, ] matrix)
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

void ReleaseMatrix(int[, ] matrix) // принимает матрицу
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1) // нечетные, делятся на 2 с остатком
            {
                matrix[i, j] *= matrix[i, j]; // то этот элемент матрицы умножается сам на себя
            }
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
Console.WriteLine("Результат: ");
ReleaseMatrix(matrix); // вызываем функцию итогового решения
