﻿int a = 2;
int b = 10;
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
Console.Write("Максимальное число:");
Console.WriteLine(max);
Console.Write("Минимальное число:");
Console.WriteLine(min);