// Напишите метод, который принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


int[] numbers = new int[5];

int[] Input(int[] array)
{
    Console.Write("Введите последовательно пятизначное число: ");
    int size = 5;
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = system.int32(Console.ReadLine());
    }
    return array;
}

void Palindrom(int[] array)
{
    int size = 5;
    int i = 0;
    if (array[i] == array[size - i - 1] && array[i + 1] == array[size - i - 2])
    {
        Console.WriteLine("Палиндром.");
    }
    else
    {
        Console.WriteLine("Не палиндром.");
    }
}
Input(numbers);
Console.WriteLine(numbers);
// Palindrom(numbers);
