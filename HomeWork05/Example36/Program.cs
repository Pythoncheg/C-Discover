// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

/*
--------------------------------------------------------------------------------------------------------------
1. Опистать метод нахождения псевдослучайного числа.
2. Описать метод создания массива.
3. Описать метод заполнения массива псеводослучайными числами.
4. Описать метод нахождения суммы элементов, стоящих на нечетных позициях.
5. Распечатать результат.
*/

// 1.

int FindRandomInt(int min, int max)
{
    return new Random().Next(min, max);
}

// 2.

int[] Create(int size)
{
    return new int[size];
}

// 3.

void Fill(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] += new Random().Next(-99, 99);
    }
}

// 4.

int SearchSum(int[] array)
{
    int size = array.Length;
    int sum = 0;
    for (int i = 1 ; i < size; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Clear();
int size = FindRandomInt(3,12);
int[] collection = Create(size);
Fill(collection);
Console.WriteLine($"Задан массив из случайных псевдочисел: " + "{" + (String.Join(' ', collection)) + "}");
int sum = SearchSum(collection);
Console.WriteLine($"Сумма всех чисел, стоящих на нечетных позициях равна: {sum}");