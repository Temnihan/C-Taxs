// : Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// только m = 2, n = 3 -> A(m,n) = 29 не верно будет 3, а вот
//        m = 3, n = 2 -> A(m,n) = 29
Console.Write(" Enter m: ");
int m= int.Parse(Console.ReadLine());
Console.Write(" Enter n: ");
int n = int.Parse(Console.ReadLine());
int akrmv(int m,int n)
{
    if (m == 0) return n+1;
    if (n == 0) return (akrmv(m-1,1));
    else
    return akrmv(m - 1, akrmv(m, n - 1));
}
Console.WriteLine(akrmv(m,n));