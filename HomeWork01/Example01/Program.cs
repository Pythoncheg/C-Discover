Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;

if(a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.WriteLine($"Максимальным числом является {max}, а минимальное разумеется {min}. Что тут не понятно то? А!?");