// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t"); // вывод нашего массива
        }
        Console.WriteLine();// переход на новую строка
    }
}

void SwapFirstLastString(int[,] matrix)// процедура, которая будет все делать, передача двумерного массива
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    // проходимся по каждому значению столбца, 
    //тк количество строк не меняется, меняются только столбцы
    {
        int temp = matrix[0, j];//проходимся по каждому значению столбца, у первой строки и у последней
        // заводим переменную темп, в не кладем массив, строка не меняется
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j]; // 1 строка меняется с последней (- 1)
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.WriteLine("\n\n");
SwapFirstLastString(matrix);