// Напишите метод, который принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


void Fill(int[] array)
{
    Console.Write("Введите последовательно пятизначное число: ");
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
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
int[] numbers = New Array[](5);
int[] numbers = Fill();
PrintArray(numbers);
// Palindrom(numbers);
