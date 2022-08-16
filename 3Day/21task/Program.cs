// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("enter xA: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("enter yA: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("enter zA: ");
int zA = int.Parse(Console.ReadLine());
Console.Write("enter xB: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("enter yB: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("enter zB: ");
int zB = int.Parse(Console.ReadLine());
double katet1 = Math.Sqrt(Math.Pow(xA -xB,2) + Math.Pow(yA -yB,2));
double dist = Math.Sqrt(Math.Pow(katet1,2) +Math.Pow(zA -zB,2));
Console.WriteLine($" you distanse {dist:f2}");
