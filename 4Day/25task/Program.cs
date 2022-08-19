//  Напишите цикл, который принимает на вход два числа (A и B)
//   и возводит число A в натуральную степень B.
int pw(int A, int B){
    int rezult = 1;
    for(int i = 1; i<=B; i++){
        rezult *=A;
    }
    return rezult;
}
Console.WriteLine("Enter A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter B: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(pw(a,b));
