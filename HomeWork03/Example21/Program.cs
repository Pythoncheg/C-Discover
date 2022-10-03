// Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √ (x b - x a) 2 + (y b - y a) 2 + (z b - z a) 2.


int Coordin(string coords, string point)
{
    Console.Write($"Введите координату {coords} точки {point}: ");

    return Convert.ToInt32(Console.ReadLine());
}

double Final(double x1, double x2, double y1, double y2, double z1, double z2)
{
                
    return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}


int x1 = Coordin("x", "A");
int y1 = Coordin("y", "A");
int z1 = Coordin("z", "A");
int x2 = Coordin("x", "B");
int y2 = Coordin("y", "B");
int z2 = Coordin("z", "B");

double distance =  Final(x1, x2, y1, y2, z1, z2);

Console.WriteLine($"Расстояние между точками равно: {distance}");