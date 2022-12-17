// Задайте двумерный массив размером m × n,
// заполненный случайными целыми числами.

void InputMatrix(int[, ] matrix) // заполнение матирицы (двумерного массива)
{
    for (int i = 0; i < matrix.GetLength(0); i++)// ф-ия matrix.GetLength(0) получает кол-во строк внутри нашего массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// ф-ия matrix.GetLength(1) получает кол-во столбцов внутри нашего массива
        {
            matrix[i, j] = new Random().Next(-10, 11); // заполнение массива случайными числами от [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine(); // вывод пустой строки после завершения внутреннего цикла for
    }
}

Console.Clear();

Console.Write("Введите размер матрицы: ");
string[] coord = Console.ReadLine().Split(" ");// принимаем размер матрицы от пользователя в строку через пробел

int row = int.Parse(coord[0]); // вводим переменную row - значение кол-ва строк (полученных от пользователя)
int column = int.Parse(coord[1]); // вводим переменную column - значение кол-ва столбцов (полученных от пользователя)
int[,] matrix = new int[row, column]; // вводим двумерный массив

InputMatrix(matrix); //заполнение и вывод нашего двумерного массива
