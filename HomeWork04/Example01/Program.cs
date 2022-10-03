string[] arr = new string[] { "9-10", "10-11", "11-12", "12-13" };


string Print(string[] array)
{
    return String.Join(',', array);
}

Console.WriteLine(Print(arr));