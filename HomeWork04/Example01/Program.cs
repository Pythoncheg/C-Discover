int[] Create(int size)
{
    return new int[size];
}

void CountVisit(int[] array, int goIn, int goOut)
{
    for (int i = goIn; i <= goOut; i++)
    {
        array[i] += 1;
    }
}

void Final(int[] array)
{
    int inVis = 0;
    int outVis = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == array.Max())
        {
            inVis = i - 1;
            outVis = inVis + 1;
        }



    }
    int[] sum = new int[] { inVis, outVis };
    Console.WriteLine(String.Join('-', sum));

}



// 10-12
// 11-13
// 9-12

// Ответ
// 11-12

int[] time = Create(24);
int goIn = 10;
int goOut = 12;
CountVisit(time, goIn, goOut);
goIn = 11;
goOut = 13;
CountVisit(time, goIn, goOut);
goIn = 9;
goOut = 12;
CountVisit(time, goIn, goOut);
Console.WriteLine(String.Join(' ', time));
Final(time);

