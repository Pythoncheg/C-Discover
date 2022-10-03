// Дан массив, нужно сформировать
// новый массив из четных чисел

// 1. Описать метод получения псевдослучайного числа от min до max
// 2. Описать метод создающий массив (с указанным колчиством элементов)
// 3. Описать метод заполнения массива псевдослучайными числами
// 4. Описать метод распечатывания массива
// 5. Описать метод нахождения четных чисел в массиве
// 6. Описать метод финального решения


// 1. Описать метод получения псевдослучайного числа от min до max
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

// 2. Описать метод создающий массив (с указанным колчиством элементов)

int[] CreateArray(int size)
{
    return new int[size];
}

// 3. Описать метод заполнения массива псевдослучайными числами

void Fill(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = GetIntValue(1, 10);
    }
}

// 4. Описать метод распечатывания массива
void Print(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// 5. Описать метод нахождения четных чисел в массиве
int SearchNumberEvenElemenstIn(int[] array)
{
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// 6. Описать метод финального решения
int[] Final(int[] data, int count)
{
    int[] evenItems = new int[count];
    int position = 0;
    int size = data.Length;
    for (int i = 0; i < size; i++)
    {
        if (data[i] % 2 == 0)
        {
            evenItems[position] = data[i];
            position++;
        }
    }
    return evenItems;
}
Console.Clear();
int length = GetIntValue(10, 20);
int[] collection = CreateArray(length);
Print(collection);
Fill(collection);
Print(collection);
int count = SearchNumberEvenElemenstIn(collection);
int[] result = Final(collection, count);
Print(result);