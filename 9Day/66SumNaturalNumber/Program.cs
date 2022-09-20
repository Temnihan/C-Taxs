// Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N
Console.Write(" Enter start: ");
int start = int.Parse(Console.ReadLine());
Console.Write(" Enter  end:  ");
int end = int.Parse(Console.ReadLine());
//  recursiv
int allSum(int A, int B)
{
    if (B == A) return A;

    return B + allSum(A,B-1);
}
Console.WriteLine(allSum(start,end));
// better variant
int allSum2(int A, int B)
{
    return (A+B)*(B-A +1)/2;
}
Console.WriteLine(allSum2(start,end));