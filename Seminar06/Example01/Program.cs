// Составить частотный словарь элементов одномерного массива

int [] arr = {};

    // int count0 = 0;
    // int count1 = 0;
    // int count2 = 0;
    // int count3 = 0;
    // int count4 = 0;
    // int count5 = 0;
    // int count6 = 0;
    // int count7 = 0;
    // int count8 = 0;
    // int count9 = 0;

int frequencyArray(int [] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) count++;
    }
    return count;
}

int countNum = frequencyArray(arr, 0);
Console.WriteLine($"Число 0 встречается {countNum} раз");
countNum = frequencyArray(arr, 1);
Console.WriteLine($"Число 1 встречается {countNum} раз");
countNum = frequencyArray(arr, 2);
Console.WriteLine($"Число 2 встречается {countNum} раз");
countNum = frequencyArray(arr, 3);
Console.WriteLine($"Число 3 встречается {countNum} раз");
countNum = frequencyArray(arr, 4);
Console.WriteLine($"Число 4 встречается {countNum} раз");
countNum = frequencyArray(arr, 5);
Console.WriteLine($"Число 5 встречается {countNum} раз");
countNum = frequencyArray(arr, 6);
Console.WriteLine($"Число 6 встречается {countNum} раз");
countNum = frequencyArray(arr, 7);
Console.WriteLine($"Число 7 встречается {countNum} раз");
countNum = frequencyArray(arr, 8);
Console.WriteLine($"Число 8 встречается {countNum} раз");
countNum = frequencyArray(arr, 9);
Console.WriteLine($"Число 9 встречается {countNum} раз");
