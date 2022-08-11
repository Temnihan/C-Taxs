// Задача 10: 
// Напишите программу, которая принимает на вход
//  трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1 
Console.Write("enter the number? please");
int number1 = int.Parse(Console.ReadLine());
number1 = number1 /10%10;
Console.WriteLine(number1);
