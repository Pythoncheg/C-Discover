

Console.Clear();
Console.Write("Введите оценки: ");
string m = Console.ReadLine();
string[] arr = m.Split(" ");

int[] ints = Array.ConvertAll(arr, s => int.Parse(s)); // Нашел этот метод в интернете.
int sum = 0;
for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] == 5) sum += 30;
    else if (ints[i] == 4) sum += 15;
    else if (ints[i] == 3) sum -= 15;
    else if(ints[i] == 2) sum -= 30;
}

Console.WriteLine(String.Join(',', ints));

Console.Write($"В данный период ты заслужил {sum} рублей.");
Console.WriteLine();
Console.Write("Нажмите Enter для выхода:");
while (Console.ReadKey().Key != ConsoleKey.Enter) {}
