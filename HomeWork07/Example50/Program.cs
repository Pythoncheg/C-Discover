
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// ===>  Доработать определение размера массива псевдослучайными числами!

int GetValue(int min, int max)
{
    return new Random().Next(min, max);
}

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}]");
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
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void SearchElement(int[,] matrix, int posX, int posY)
{
    if (posX < matrix.GetLength(0) && posY < matrix.GetLength(1))
    {
        Console.Write("Искомый элемент " + matrix[posX, posY]);
    }
    else Console.WriteLine("Неверный адрес, такого числа нет в массиве.");
}

Console.Clear();
int rowsi = GetValue(2,15);
int columsi = GetValue(2, 15);
int[,] collection = new int[rowsi, columsi];
Fill(collection);
PrintArray(collection);

Console.Write("Введите номер строки и столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int rows = m / 10 - 1;
int colums = m % 10 - 1;
SearchElement(collection, rows, colums);
