Console.Write("Enter number: ");
int count = int.Parse(Console.ReadLine());
int i = 1;
while (i<=count)
{
    if (i/2*2 == i)
    {
        Console.WriteLine(i);
    }
    i++;
}