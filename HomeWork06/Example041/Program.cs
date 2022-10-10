// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3 <- <- <-!!!Тут ошибка? 4 числа больше 0.
Console.Clear();
Console.Write("Введите массив чисел: ");
string m = Console.ReadLine();
string[] arr = m.Split(" ");

// Вот тут я не смог конвертировать массив строк в массив чисел.
// int[] Convert(string [] strArr)
// {
//     int[] numArr = new int[strArr.Length];

//     for (int i = 0; i < strArr.Length; i++)
//     {
//        numArr[i] = Convert.ToInt32(strArr[i]);
//     }
//     return numArr;
// }

int[] ints = Array.ConvertAll(arr, s => int.Parse(s)); // Нашел этот метод в интернете.

int numMore0(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine(String.Join(',', ints));
int sum = numMore0(ints);
Console.Write($"В данном масиве {sum} чисел больше нуля.");