// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Amn = m + n.
// Выведите полученный массив на экран

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j; // Amn = m + n
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
//создаем массив, где каждый элемент (даже введенные пользователем "цифры") это строка.
// мы берем и проходимся функцией Select по каждому элементу массива, 
// переводим элемент в число функцией int.Parse и возвращаем набор чисел в массив функцией ToArray
int[,] matrix = new int[coord[0], coord[1]]; // ввод двумерного массива без новых переменных row/column для рядов и столбцов 
InputMatrix(matrix);
