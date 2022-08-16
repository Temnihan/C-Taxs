// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Enter numbers of 5 number: ");
int num = int.Parse(Console.ReadLine());
if (num % 10 == num /10000 &&  num %100/10 == num/1000%10){
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("NO");
}