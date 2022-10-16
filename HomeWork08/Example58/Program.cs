
// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// ==============================================================
// Произведением двух матриц А и В называется матрица С,
// элемент которой, находящийся на пересечении i-й строки и j-го столбца,
// равен сумме произведений элементов i-й строки матрицы А на соответствующие (по порядку)
// элементы j-го столбца матрицы В.


void Fill(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 6);
        }
    }
}

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

int[,] MultiplicationMatrix(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                matrC[i, j] += matrA[i, k] * matrB[k, j];
            }
        }
    }
    return matrC;
}

Console.WriteLine("Задана первая матрица: ");
Console.WriteLine();
int[,] arrayA = new int[2,2];
Fill(arrayA);
PrintArray(arrayA);
Console.WriteLine();
Console.WriteLine("Задана вторая матрица: ");
Console.WriteLine();
int[,] arrayB = new int[2,2];
Fill(arrayB);
PrintArray(arrayB);
Console.WriteLine();
Console.WriteLine("Произведение этих матриц: ");
Console.WriteLine();
int[,] arrayC = MultiplicationMatrix(arrayA, arrayB);
PrintArray(arrayC);
Console.WriteLine();
