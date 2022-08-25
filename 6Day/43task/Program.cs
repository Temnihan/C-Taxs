// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("y = k1 * x + b1: enter");
Console.Write("Ener k1 :");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Ener b1 :");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("y = k2 * x + b2: enter");
Console.Write("Ener k2 :");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Ener b2 :");
int b2 = int.Parse(Console.ReadLine());
double fx(int k1, int b1, int k2, int b2){
    return (double)(b2-b1)/(k1-k2);
    // return 0.5;
}
double x = fx(k1,b1,k2,b2);
double y = k1*x + b1;
Console.WriteLine($" x = : {x} y = {y}");