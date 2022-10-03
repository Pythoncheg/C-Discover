Console.Clear();
double[] n = new double[] {1, 2, 3, 5, 5, 6, 7};
double sum = 0;
int i = 0;
int size = n.Length;

while(i < size)
{
    sum = n[i] + sum;
    i++;
}
double avg = sum / size;
Console.WriteLine($"Общее арифметическое заданных чисел будет {avg}.");