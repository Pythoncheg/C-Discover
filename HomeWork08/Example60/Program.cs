// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Описать метод сравнения элементов в массиве.

bool SearchRepeatingNum(int[,,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == element) return true;
            }
        }
    }
    return false;
}

// Описать метод заполнения массива псевдослучайными уникальными числами.

void Fill(int[,,] matrix)
{
    int index;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                index = new Random().Next(10, 100);
                if (SearchRepeatingNum(matrix, index)) 
                {
                    i--;
                    continue;
                }
                matrix[i, j, k] = index;
            }
            // int k = 0;
            // while (k < matrix.GetLength(2))
            // {
            //     index = new Random().Next(10, 100);
            //     if(SearchRepeatingNum(matrix, index)) continue;
            //     matrix[i, j, k]=index;
            //     k++;
            // }
        }
    }
}

// Описать метод распечатывания массива.

void PrintArray(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} {(i, j, k)} ");
            }
            Console.WriteLine();
        }
    }
}


Console.Clear();
Console.WriteLine("Сформирован трехмерный массив из неповторяющихся двузначных чисел: ");
Console.WriteLine();
int[,,] collection = new int[2, 2, 2];
Fill(collection);
PrintArray(collection);
Console.WriteLine();
Console.WriteLine("В скобках указан индекс числа.");




