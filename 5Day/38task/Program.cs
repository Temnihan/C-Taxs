// Задайте массив вещественных чисел. Найдите разницу
//  между максимальным и минимальным элементов массива
int[] arr(int size, int st, int end)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(st, end + 1);
    }
    return res;
}
Console.WriteLine(" Enter size massiv");
int s = int.Parse(Console.ReadLine());
int[] array = arr(s, 0, 10);
Console.WriteLine(string.Join(" ", array));
int difer(int[] mas)
{
    int mx = mas[0];
    int mn = mas[0];
    foreach (int el in mas){
        if (el > mx){
            mx = el;
        }
        else if (el <mn){
            mn = el;
        }
        
    }
return mx -mn;
}
Console.WriteLine(difer(array));