// Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от 1 до N
Console.WriteLine(" Enter number: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write($"{i} ");
}
Console.WriteLine();
Console.WriteLine(" Enter start: ");
int s = int.Parse(Console.ReadLine());
void printN(int start, int N)
{
    if (N<start) return;
    printN(start, N-1);
    Console.Write(N + ", ");
}
printN(s,n);
Console.WriteLine();

string printTwo(int start, int end)
{
    if (start == end) return n.ToString();
    return start + " " + printTwo(start+1, end);
}
Console.WriteLine(printTwo(s,n));
