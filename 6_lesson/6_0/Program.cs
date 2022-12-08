Console.Clear();
// Генерация случайных дробных чисел
//                                        * (end - begin) + begin
double number = (new Random().NextDouble() * (50 - 10) + 10, 2); // [0, 1] 
// ... + 10, 2) - 2 знака после запятой
// [begin; end]
Console.WriteLine(number);
