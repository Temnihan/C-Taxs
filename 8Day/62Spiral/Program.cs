// Заполните спирально массив 4 на 4.;
//  -------------------   Create massive  ----------------
Console.Write(" enter y ");
int y = int.Parse(Console.ReadLine());
Console.Write(" enter x ");
int x = int.Parse(Console.ReadLine());
int[,] GetArray(int m, int n)
{
    int s = 1;
    int[,] result = new int[m, n];
    for (int i = 0; i < n; i++)
    {
        result[0,i]=s;
        s++;
    }
    for (int i = 1; i < m; i++)
    {
        result[i,n-1] = s;
        s++;
    }
    for (int i = n-2; i>=0 ; i--)
    {
        result[m-1,i]= s;
        s++;
    }
    for (int i = m-2; i >0; i--)
    {
        result[i,0] = s;
        s++;
    }
    int x =1; int y =1;
    // if (result[y,x] != 0) return result;
    // else { result[y,x] = s; s++;}
    
    while(s<m*n)
    {
        // move right
        while( result[y,x+1] ==0)
        {
            result[y,x] = s;
            s++;
            x++;
        }
        // move down
        while(result[y+1,x] == 0)
        {
            result[y,x] =s;
            s++;
            y++;
            Console.WriteLine($"yess S = {s}");
        }
        // move left
        while(result[y,x-1] == 0)
        {
            result[y,x] = s;
            s++;
            x --;
        }
        // move up
        while(result[y-1,x] == 0)
        {
            result[y,x] = s;
            s++;
            y --;
        }
        // s++;
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (result[y,x] == 0)
            result[y,x] = s;
        }
    }

    return result;
}
int[,] myArray = GetArray(y, x);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if( array[i,j]<10)
            Console.Write($"  {array[i, j]}");
            else Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }

}
PrintArray(myArray);
Console.WriteLine(" -----------------");
