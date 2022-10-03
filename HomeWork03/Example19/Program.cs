// Напишите метод, который принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
#region

int[] CreateArray(int size)
{
    return new int[size];
}

void Fill(int[] array)
{
    Console.WriteLine("Введите последовательно пять чисел от 1 до 9 для проверки на полиндром: ");
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
        if (array[i] > 9)
        {
            Console.WriteLine("Введено не корректное число!");
            i--;
        }
    }
}
void Print(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
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
#endregion

Console.Clear();
int length = 5;
int[] numbers = CreateArray(length);
Fill(numbers);
Print(numbers);
Palindrom(numbers);
