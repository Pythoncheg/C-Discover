
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 1. Находим X и Y.
// k1 * x + b1 = k2 * x + b2
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

// 2. Проверить разные ли точки.
// 3. Добавить проверку пересекаются ли прямые.

#region 
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double intersectionPointX = 0;
double intersectionPointY = 0;
#endregion

if (b1 == b2 && k1 == k2) Console.WriteLine("Ваши точки совпадают, прямая ОДНА!");
else if (k1 == k2) Console.WriteLine("Эти прямые не пересекаются!");
else
{
    intersectionPointX = (b2 - b1) / (k1 - k2);
    intersectionPointY = k1 * intersectionPointX + b1;
    Console.WriteLine($"Точки пересечения прямых: ( {intersectionPointX} ; {intersectionPointY})");
}
