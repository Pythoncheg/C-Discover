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

int[] Final(int[] array)
{
    int in = 0;
    int out = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == array.Max()) in = i;
        
        if(in > 0) out = i;
        
    
        
    }
    int[] sum = new int[]{in, out};
    Console.WriteLine(String.Join('-'));

}

// int InOutTime(string in)
// {
//     string[] arr = in.Split('-');
//     int goIn = Convert.ToInt32(arr[0]);
//     int goOut = Convert.ToInt32(arr[1]);
//     return goIn;
// }

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
