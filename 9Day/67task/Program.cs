// Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
Console.WriteLine(" Enter number: ");
int n = int.Parse(Console.ReadLine());
int sumNubres(int N)
{

    if (N < 10) return (N%10);
    return N%10+ sumNubres(N/10);
}
Console.WriteLine(sumNubres(n));