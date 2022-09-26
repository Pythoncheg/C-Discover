Console.Clear();
int[] n = new int[] {1, 2, 3, 4, 5, 6, 7};
int sum = 0;
int i = 0;
int size = n.Length;

while(i < size)
{
    sum = n[i] + sum;
    i++;
}
int avg = sum / size;
Console.WriteLine($"Общее арифметическое заданных чисел будет {avg}.");