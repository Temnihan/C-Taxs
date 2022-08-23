// Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
int [] arr(int size, int st, int end){
    int [] res = new int[size];
    for (int i = 0; i<size; i++){
        res[i] = new Random().Next(st, end+1);
    }
    return res;
}
Console.WriteLine(" Enter size massiv");
int s = int.Parse(Console.ReadLine());
int[] array  = arr(s, 000,10);
Console.WriteLine(string.Join(" ",array));
int nechet (int [] ar){
    int Sum = 0;
    for (int i =1; i<ar.Length; i+=2){
        Sum+=ar[i];
    }
    return Sum;
}
Console.WriteLine(nechet(array));