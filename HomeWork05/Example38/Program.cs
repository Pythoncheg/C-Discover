﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
/*
---------------------------------------------------------------------------
1. Опистать метод нахождения псевдослучайного числа.
2. Описать метод создания массива.
3. Описать метод заполнения массива псеводослучайными числами.
4. Распечатать полученный массив.
5. Найти максимальное и минимальное число.
6. Найти разницу между максимальным и минимальным числом.
7. Распечатать результат.
---------------------------------------------------------------------------
*/
// 1. Опистать метод нахождения псевдослучайного числа.
int FindRandomInt(int min, int max)
{
    return new Random().Next(min, max);
}
// 2. Описать метод создания массива.
int[] Create(int size)
{
    return new int[size];
}
// 3. Описать метод заполнения массива псеводослучайными числами.
void Fill(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = array[i] + new Random().Next(1, 99);
    }
}


Console.Clear();
int size = FindRandomInt(4,12);
int[] collection = Create(size);
Fill(collection);

// 4.Распечатать полученный массив.
Console.WriteLine($"Задан массив из случайных псевдочисел: " + "{" + (String.Join(' ', collection)) + "}");

// 5. Найти максимальное и минимальное число.
Console.WriteLine("Максимальное число " + collection.Min());
Console.WriteLine("Минимальное число " + collection.Max());

// 6. Найти разницу между максимальным и минимальным числом.
int differece = collection.Max() - collection.Min();

// 7. Распечатать результат.
Console.WriteLine("Разница между максимальным и минимальным: " + differece);