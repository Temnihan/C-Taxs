//Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
//  1    ----- create Array  -----------------
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
int m = new Random().Next(1, 9);
int n = new Random().Next(3, 10);
int[,] myArray = GetArray(m, n, 0, 100);
// 2.  ---- Show Array  -----------
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

void Arifmetich(int[,] array)
{
    int[] newArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j]+=array[i,j];
        }
    }
 
    Console.WriteLine(string.Join(" ",newArray));

}
Console.WriteLine();
Arifmetich(myArray);