// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// --------------------------------------------------------------------------------------------

/*
1. Описать метод получения псевдослучайного числа от min до max.
2. Описать метод создания массива.
3. Описать метод заполнения массива положительными трехзначными псевдослучайными числами.
4. Описать метод поиска количества четных чисел в массиве.
-----------------------------------------------------------------------------------------------*/
#region 
// 1. Описать метод получения псевдослучайного числа от min до max.

int GetValue(int min, int max)
{
    return new Random().Next(min, max);
}

// 2. Описать метод создания массива.

int[] Create(int size)
{
    return new int[size];
}

// 3. Описать метод заполнения массива положительными трехзначными псевдослучайными числами.

void Fill(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = array[i] + new Random().Next(100, 999);
    }
}

// 4. Описать метод поиска количества четных чисел в массиве.

int FindingEvenNumbers(int[] array)
{
    int size = array.Length;
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}
#endregion

Console.Clear();

int size = GetValue(2, 10);
int[] array = Create(size);
Fill(array);
Console.Write("Задан массив с псевдослучайными числами: ");
Console.WriteLine("[" + String.Join(' ', array) + "]");
int sum = FindingEvenNumbers(array);
if (sum == 0)
{
    Console.WriteLine("В этом массиве нет четных чисел");
}
if (sum == 1)
{
    Console.WriteLine($"В этом массиве найдено {sum} четное число.");
}
if (sum >= 2 && sum <= 4)
{
    Console.WriteLine($"В этом массиве найдено {sum} четных числа.");
}
if (sum > 4)
{
    Console.Write($"В этом массиве найдено {sum} четных чисел.");
}
