﻿// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 2D пространстве.

от Rustem для Все (20:03)
можно сходу тупой вопрос?)
значит мне нужно создать новую ветку и снова залить туда задания все?
от Смирнов Кирилл для Все (20:06)
у меня в дз в 1 задаче написано : число принимает на вход, а во 2 : выводит случайное значение. Соответственно в первой с консоли, а во второй соответственно new Random()
от artur для Все (20:07)
у меня не получается  дз 1 отправить, pull request, этой кнопки не вышло...
от Rustem для Все (20:08)
compare and pull request появляется после создания 2х отдельных веток?
у меня такая кнопка не появилась.
раньше все норм было, сейчас видимо что-то забыл
от ILYA VEDERNIKOV для Все (20:08)
Нет кнопки пул реквест
от Евгения для Все (20:08)
как переключиться на англ.яз в VSCode
спасибо
от Анна Живницкая для Все (20:12)
это решение гуманитариев))
от Надежда Шипилова для Все (20:13)
стрелочка в коде это как понимать? что она делает?
От меня пользователю Все (20:13)
а две палки?))
от Надежда Шипилова для Все (20:13)
то есть без нее тоже работает?
от Maria для Все (20:17)
не принципиально в каком порядке идет фунция,а потом вызов функции?
можно наоборот
от Глеб Н. для Все (20:18)
а если 99 зайдет?
от Анна Живницкая для Все (20:20)
почему нельзя написать num == 6 | 7  ? ну или у меня не получилось)
от Maria для Все (20:22)
надо в main перейти
от artur для Все (20:22)
слипнется
от Мария Андреева для Все (20:27)
// 1. Напишите программу, которая принимает на вход координаты точки (X и Y),
//    причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
от Никита Полднев для Все (20:27)
всем привет. немного опоздал((
отлично)
от Смирнов Кирилл для Все (20:31)
|| это или?
&& это "и"
от Мария Андреева для Все (20:34)
void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0 or y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}

Quarters(10, -9);
// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).
от Maria для Все (20:36)
я могу
от kat для Все (20:38)
Ой кошмар
от Rustem для Все (20:38)
у меня одного лагало?)
от Maria для Все (20:42)
void Quarters(string a)
{
    if (a == "I")
        Console.WriteLine("x > 0 and y > 0");
    else if (a == "II")
        Console.WriteLine("x < 0 and y > 0");
    else if (a == "III")
        Console.WriteLine("x < 0 and y < 0");   
    else if (a == "IV")
        Console.WriteLine("x > 0 and y <  0");
    else 
        Console.WriteLine("error");       

}
Quarters(Console.ReadLine());
от Мария Андреева для Все (20:42)
https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/
от Maria для Все (20:44)
float
от Мария Андреева для Все (20:45)
// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 2D пространстве.
от Yakov Pn для Все (20:45)
Давайте я попробую ))
от Maria для Все (20:48)
ReadNumder подскажите что значит
от andre для Все (20:48)
все понятно, классное объяснение)
от andre для Все (20:49)
ток музыку поставить бы еще)
от Maria для Все (20:49)
ввод числа? чтоб Parse не испоьзовать?
от Надежда Шипилова для Все (20:52)
строчку 5 прям подробно можно обьяснить?
от Анна Живницкая для Все (20:52)
5 cnhjre j,mzcybnt
5 строку объясните
от Надежда Шипилова для Все (20:53)
конвертирование понятно
не понтно до него
от Мария Андреева для Все (20:54)
https://codechick.io/tutorials/csharp/csharp-ternary-operator
от Игорь для Все (20:54)
скиньте код пожалуйста
от Rustem для Все (20:55)
а что будет если одна из координат будет 0?
если мы введем пустую сроку, то будет 0?
от nikolaydanyukin для Все (20:56)
Запускается с ошибкой
от Надежда Шипилова для Все (20:57)
скинтье код пожалуйста
от Maria для Все (20:57)
код отправьте пожалуйста
от Yakov Pn для Все (20:57)
int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
double Distance(int ax, int ay, int bx, int by)
{
    double result;
    result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
    return result;
}

int ax = ReadNumber("Введите aX:");
int ay = ReadNumber("Введите aY:");
int bx = ReadNumber("Введите bX:");
int by = ReadNumber("Введите bY:");

Console.WriteLine(Math.Round(Distance(ax, ay, bx, by), 2));