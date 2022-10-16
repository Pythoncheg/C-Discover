
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Fill(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

int SearchLineLowValue(int[,] matrix)
{
    int minLine = 0;
    int sum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp += matrix[i, j];
        }

        if (temp < sum)
        {
            sum = temp;
            minLine = i;
        }

    }
    return minLine;
}

int[,] collection = new int[4, 4];
Fill(collection);

Console.Clear();
Console.WriteLine("Задан массив: ");
Console.WriteLine();

PrintArray(collection);
Console.WriteLine();

int min = SearchLineLowValue(collection);

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {min + 1}.");
