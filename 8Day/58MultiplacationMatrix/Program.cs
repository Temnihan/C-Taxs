// Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
//  -------------------   Create massive  ----------------
Console.Write(" enter m1 ");
int m1 = int.Parse(Console.ReadLine());
Console.Write(" enter m2 ");
int m2 = int.Parse(Console.ReadLine());
Console.Write(" enter n1 ");
int n1 = int.Parse(Console.ReadLine());
Console.Write(" enter n2 ");
int n2 = int.Parse(Console.ReadLine());
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);

        }
    }
    return result;
}
int[,] myArray1 = GetArray(m1, n1, 0, 10);
int[,] myArray2 = GetArray(m2, n2, 0, 10);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }

}
PrintArray(myArray1);
Console.WriteLine(" -----------------");
PrintArray(myArray2);
int[,] Multiplication(int[,] array1, int[,] array2)
{
    int m1 =  array1.GetLength(0);
    int n1 =  array1.GetLength(1);
    int m2 =  array2.GetLength(0);
    int n2 =  array2.GetLength(1);
    int[,] result = new int[m1,n2];
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            for (int k = 0; k < m2; k++)
            {
                // Console.WriteLine($"r {result[i,j]} +  A {array1[i,k]} * B {array2[k,j]}");
                result[i,j] += array1[i,k]*array2[k,j];
            }
        }
    }
    return result;
}
int[,] multResul = Multiplication(myArray1,myArray2);
Console.WriteLine(" -----------------");
PrintArray(multResul);