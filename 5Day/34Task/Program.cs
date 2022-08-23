// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
//  количество чётных чисел в массиве.
int [] arr(int size, int st, int end){
    int [] res = new int[size];
    for (int i = 0; i<size; i++){
        res[i] = new Random().Next(st, end+1);
    }
    return res;
}
Console.WriteLine(" Enter size massiv");
int s = int.Parse(Console.ReadLine());
int[] array  = arr(s, 100,999);
Console.WriteLine(string.Join(" ",array));
int chetMassiv (int [] ar){
    int Sum = 0;
    foreach( int el in ar){
        if (el %2 ==0) Sum++;
    }
    return Sum;
}
Console.WriteLine(chetMassiv(array));