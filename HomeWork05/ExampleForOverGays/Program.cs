// Написать программу премножения любых целых чисел

Console.Write("Введите первое число: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());
double sum = secondNumber * firstNumber;
Console.WriteLine($"Произведение чисел равно: {sum}");