

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// // int[,] collection = new int[,]
// {
//     {1, 4, 7, 2},                    <== Это использовано как проверка решения.
//     {5, 9, 2, 3},
//     {8, 4, 2, 4}
// };

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

void Fill(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] collection = new int[3, 4];
Fill(collection);

Console.Clear();
Console.WriteLine("Задан массив: ");
Console.WriteLine();


PrintArray(collection);

double colums1 = Math.Round(((collection[0, 0] +
                 collection[1, 0] +
                 collection[2, 0]) / 3.0), 1,
                 MidpointRounding.ToZero);
double colums2 = Math.Round(((collection[0, 1] +
                 collection[1, 1] +
                 collection[2, 1]) / 3.0), 1,
                 MidpointRounding.ToZero);
double colums3 = Math.Round(((collection[0, 2] +
                 collection[1, 2] +
                 collection[2, 2]) / 3.0), 1,
                 MidpointRounding.ToZero);
double colums4 = Math.Round(((collection[0, 3] +
                 collection[1, 3] +
                 collection[2, 3]) / 3.0), 1,
                 MidpointRounding.ToZero);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца: {colums1}; {colums2}; {colums3}; {colums4}.");
Console.WriteLine();
