﻿// Задайте двумерный массив размером m × n,
// заполненный случайными целыми числами.

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);
int[,] matrix = new int[row, column];
InputMatrix(matrix);
