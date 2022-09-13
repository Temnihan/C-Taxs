// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
void newArray(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    if (m != n)
    {
        Console.WriteLine("not possible");
    }
    else
    { int tmp;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < m; j++)
            {
              tmp = array[i,j];
              array[i,j] = array[j,i];
              array[j,i] = tmp;  
            }
        }
    }

}
 newArray(myArray);
 Console.WriteLine();
PrintArray(myArray);
