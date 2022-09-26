﻿

// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Задано число - {n}.");
if(n < 99)
{
    Console.WriteLine("Нет третьей цифры!");
}
else
{
    while(n > 999)
    {
        n = n / 100;
    }

    n = n % 10;
    Console.WriteLine($"Третья цифра в данном числе - {n}.");
}



