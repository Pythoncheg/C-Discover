int even = 2;
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

while(even <= n)
{
    Console.Write(even + " ");
    even += 2;
}
Console.WriteLine("End");