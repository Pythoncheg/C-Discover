int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
int numberB = new Random().Next(1, 10);
int result = numberA + numberB;
Console.Write("Первое число: ");
Console.WriteLine(numberA);
Console.Write("Второе число: ");
Console.WriteLine(numberB);
Console.Write("Сумма этих чисел равна: ");
Console.WriteLine(result);