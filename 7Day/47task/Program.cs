// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
Console.Write("m = :");
int m =  int.Parse(Console.ReadLine());
Console.Write("n = :");
int n = int.Parse(Console.ReadLine());
void PrintArray( double[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($" {array[i,j]}");
               
            }        
        Console.WriteLine();
        } 
}

double [,] GetArray(int m, int n){
    double [,] result = new double [m,n];
    for (int i = 0; i < m; i++)
        { 
        for (int j = 0; j < n; j++)
            {
                result[i,j] = Math.Round(new  Random().NextDouble(), 2);
                // result[i,j] = new  Random().NextDouble();
            
            }
        }
        return result;
    }
double [,] myArray = GetArray(m,n);
PrintArray(myArray);
