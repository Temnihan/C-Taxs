//Задайте двумерный массив.
//  Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
//  -------------------   Create massive  ----------------
Console.Write(" enter m ");
int m = int.Parse(Console.ReadLine());
Console.Write(" enter n ");
int n = int.Parse(Console.ReadLine());
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
int[,] myArray = GetArray(m, n, 0, 100);

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
PrintArray(myArray);
Console.WriteLine(" -----------------");
void SortMatrix(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int[] tmp = new int[n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tmp[j] = array[i,j];
        }
        SortArray(tmp);
        for (int j = 0; j < n; j++)
        {
            array[i,j] = tmp[j];
        }
    }
}
void SortArray(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        for (int j = i+1; j <= n-1; j++)
        {
            if (array[i]< array[j])
            {
                int tmp;
                tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
        }
    }
}

SortMatrix(myArray);
PrintArray(myArray);
