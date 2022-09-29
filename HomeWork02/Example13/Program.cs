

// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Задано число - {number}.");
if(number < 99)
{
    Console.WriteLine("Нет третьей цифры!");
}
else
{
    while(number > 999)
    {
        number = number / 10;
    }

    number = number % 10;
    Console.WriteLine($"Третья цифра в данном числе - {number}.");
}



