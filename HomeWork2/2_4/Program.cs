// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write ("Введите порядковый номер дня недели: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number<1||number>7)
Console.WriteLine ("С таким номером дня недели не существует");
else if (number > 5) {
Console.WriteLine ("Ура, долгожданный выходной!");
}
else Console.WriteLine ("Трудовой будничный день");