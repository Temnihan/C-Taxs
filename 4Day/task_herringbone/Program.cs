// Напишите функцию, которая принимает одно число -
//  высоту елочки и рисует ее в консоли звездочками.
Console.WriteLine("Eneter number");
int N = int.Parse(Console.ReadLine());
//int size = N * 2 - 1;
for (int i = 1; i <= N; i++)
{
    int str = N - i;
    for (int j = 0; j < str; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i * 2 - 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();

}