int numerR = new Random().Next(100, 1000);
Console.WriteLine(numerR);
int a3 = numerR % 10;
int a1 = numerR / 100;
Console.WriteLine($"{a1}{a3}");
