// Напишите метод, который принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
int[] numbers = {1, 2, 3, 2, 1};
int size = numbers.Length;

void Method(int[] numbers)
{
    for(i = 0; i < size / 2; i++);
    {
        if (numbers[i] == numbers[size - 1 - i]);
    }
    Console.WriteLine("Палиндром.");
}