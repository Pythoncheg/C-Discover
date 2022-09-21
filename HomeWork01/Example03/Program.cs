Console.Write("Введите число для его проверки: ");
string n = Console.ReadLine();
int a = n;
if(a % 2 == 0 )
{
    Console.Write("Число ");
    Console.Write(n);
    Console.WriteLine(" четное.");
}
else
{
    Console.Write("Число ");
    Console.Write(n);
    Console.WriteLine(" НЕчетное.");
}