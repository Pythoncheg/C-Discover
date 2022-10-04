int[] Create(int len)
{
    return new int[len];
}

void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

string Print(int[] array)
{
    return String.Join(", ", array);
}

int Search(int[] array, int findMin, int findMax)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] >= findMin && array[i] <= findMax)
        {
            count++;
        }
    }
    return count;
}

int[] arr = Create(12);
Console.WriteLine(Print(arr));
Fill(arr, 1, 200);
Console.WriteLine(Print(arr));
Console.WriteLine(Search(arr, 10, 99));
