Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc =30,
    e = 1, n = 31;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = yb;

int count = 0;

while(count < 10200)
{
    int what = new Random().Next(0, 3); // Рандом выдаст числа от 0 до 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
Console.SetCursorPosition(e, n);