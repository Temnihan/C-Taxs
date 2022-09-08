// программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
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
Console.Write("Input line: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Input row: ");
int row = int.Parse(Console.ReadLine());
// check  index exist
string checkIndex(int[,] array, int l, int r)
{   
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    if (l <m && r <n)
    {
        return array[l,r].ToString();
    }
    return "Element no exixst";
}
Console.WriteLine(checkIndex(myArray, line, row));