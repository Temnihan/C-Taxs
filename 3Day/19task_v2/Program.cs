// Напишите программу,
//  которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
string palidrom = "Yes";
int razr = 1;
int LeftNumber(int n){
    if (n/10 >0) {
        razr = razr * 10;
        // Console.Write($" razr = {razr}");
        return LeftNumber(n/10);
    }
    return n;
}
Console.WriteLine("Enter numbers : ");
int num = int.Parse(Console.ReadLine());
int Left = LeftNumber(num);

while (num/10 >10){
    razr = 1;
    if (num%10 != LeftNumber(num)){
        palidrom = "No";
        break;
    }
    else{
        num = num%razr;
        num = num/10;
    }
}
Console.WriteLine($"  {palidrom}");