Console.Write("Enter number a: ");
int mxA = int.Parse(Console.ReadLine());
Console.Write("Enter number b: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Enter number c: ");
int numberC = int.Parse(Console.ReadLine());
if (numberB >mxA)
{
    mxA = numberB;
}
if (numberC>mxA)
{
    mxA = numberC;
}
Console.WriteLine($"max number is: {mxA}");