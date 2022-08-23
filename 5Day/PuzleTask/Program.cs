// Разобраться с алгоритмом сортировки методом пузырька. 
// Реализовать невозрастающую сторировку.
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
void  sorts(int [] mas){
    int tmp = 0;
    for (int i = 0; i< mas.Length -1; i++){
        for (int j = 0; j<mas.Length-1 -i; j++){
            if (mas[j+1]>mas[j]){
                tmp=mas[j+1] ;
                mas[j+1] = mas[j];
                mas[j] = tmp;
            }
        }
        
    }
    // return mas;
}
// int [] nemas = sorts(array);
sorts(array);
Console.WriteLine(string.Join(" ",array));