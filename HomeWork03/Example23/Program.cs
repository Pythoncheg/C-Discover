// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void Method(int n) 
{
    double sum = 1;
    for (int i = 1; i <= n; i++)
    {
        sum = Math.Pow(i, 3); 
        Console.Write($"{sum}, ");
    }
}
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Method(number);
