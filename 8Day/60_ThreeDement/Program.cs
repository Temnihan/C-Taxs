// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
//  -------------------   Create massive  ----------------
Console.Write(" enter y ");
int y = int.Parse(Console.ReadLine());
Console.Write(" enter x ");
int x = int.Parse(Console.ReadLine());
Console.Write(" enter z ");
int z = int.Parse(Console.ReadLine());
int[,,] GetArray(int y, int x, int z, int minValue, int maxValue)
{
    int[] unic = new int[x * y * z];
    int[,,] result = new int[y, x, z];
    int r = 0;
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            for (int k = 0; k < z; k++)
            {
                // result[i, j, k] = new Random().Next(minValue, maxValue + 1);
                // unic[r] = new Random().Next(minValue, maxValue + 1);
                unic[r] = unicNumber(unic, minValue, maxValue);

                result[i, j, k] = unic[r];
                // unic[r] = result[i, j, k];
                r++;


            }
        }
    }
    // Console.WriteLine(String.Join(" ", unic));
    return result;
}
int[,,] myArray = GetArray(y, x, z, 10, 100);

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {

                Console.Write($" {array[i, j, k]} ({i},{j},{k})");
            }
            Console.Write(" -- ");
        }
        Console.WriteLine();
    }

}
PrintArray(myArray);
Console.WriteLine(" -----------------");
int unicNumber(int[] array, int minValue, int maxValue)
{
    int l = array.Length;
    int num = new Random().Next(minValue, maxValue + 1);
    bool flag = true;
    while (flag)
    {
        num = new Random().Next(minValue, maxValue + 1);
        for (int i = 0; i < l; i++)
        {
            if (num == array[i])
            {
                flag = true;
                break;
            }
            if (i == l - 1) flag = false;
        }

    }


    return num;
}


