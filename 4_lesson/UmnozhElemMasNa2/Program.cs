// Процедура. Умножение каждого элемента заданного массива на 2

void numbersMax(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= 2;
}


Console.Clear();
int[] array = {1, 2, 3, 4, 5};
numbersMax(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
