

Console.Clear();
Console.Write("Введите оценки: ");
string m = Console.ReadLine();
string[] arr = m.Split(' ', ',', '-');

int[] estimates = Array.ConvertAll(arr, s => int.Parse(s)); // Нашел этот метод в интернете.
int sum = 0;
for (int i = 0; i < estimates.Length; i++)
{
    if (estimates[i] == 5) sum += 30;
    else if (estimates[i] == 4) sum += 15;
    else if (estimates[i] == 3) sum -= 15;
    else if (estimates[i] == 2) sum -= 30;
}

Console.WriteLine(String.Join(',', estimates));
if (sum > 0) Console.WriteLine($"В данный период ты заслужил {sum} рублей.");
else if(sum == 0)Console.WriteLine("Ты ничего не заработал, страйся лучше!");
else
{
    int sums = Math.Abs(sum);
    Console.WriteLine($"На данный момент ты должен отдать: {sums} рублей.");
}
Console.WriteLine();
Console.Write("Нажмите Enter для выхода:");
while (Console.ReadKey().Key != ConsoleKey.Enter) { }
