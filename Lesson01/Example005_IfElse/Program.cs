Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "лариса")
{
        Console.WriteLine("Ура, это же Лариса!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}