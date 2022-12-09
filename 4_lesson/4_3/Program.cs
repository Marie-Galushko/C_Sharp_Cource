//Задача 28: Напишите программу, которая принимает 
// на вход число N и выдаёт произведение чисел от 1 до N.
// 1*2*3*4...


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 2; i <= n; i++) // i = i+1, i=2, тк счет ведем от 1*2 = 2
    result = result * i;
Console.WriteLine($"Результат: {result}");

// 2 вариант Марии 

int Proiz(int num)
	{
	    int all_sum = 1;
	    for (int i = 1; i <= num; i++)
	    {
	        all_sum = all_sum * i;
	    }
	    return all_sum;
	}
	
	Console.WriteLine(Proiz(int.Parse(Console.ReadLine())));