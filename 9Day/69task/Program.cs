// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
Console.WriteLine(" Enter number: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(" Enter stepen: ");
int st = int.Parse(Console.ReadLine());
int stepen(int A,int B)
{
    if (B==0) return 1;
    return A* stepen( A, B-1);
}
Console.WriteLine(stepen(n,st));
Int64 stepen2 (int A, int B)
{
    if (B == 0) return 1;
    else if (B % 2 == 0)  return stepen2 (A*A, B/2);
    else return A * stepen2(A, B-2);
}