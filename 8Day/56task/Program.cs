// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов
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
int lessSumline(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int lesSum ;
    int minLine = 0;
    int[] tmp = new int[n];
    for (int i = 0; i < n; i++)
    {
        tmp[i] = array[0,i];
    }
    lesSum = sumLine(tmp);
    for (int i = 1; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tmp[j] = array[i,j];
        }
        if (sumLine(tmp)< lesSum)
        {
            lesSum = sumLine(tmp);
            minLine = i;
        }
        
    }
    return minLine;
}
int sumLine(int[] array)
{
    int n = array.Length;
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum+= array[i];
    }
    return sum;
}
Console.WriteLine($" min line is {lessSumline(myArray)}");