// Задача 13: Напишите программу, которая выводит
//  третью цифру заданного числа или сообщает,
//   что третьей цифры нет. (Строки и циклы в решении использовать нельзя!)
Console.Write("enter the number? please: ");
int number1 = int.Parse(Console.ReadLine());
int thirdNumber(int SomeNumbers)
{
    if (SomeNumbers /10>99){
        return thirdNumber(SomeNumbers/10);
    }
    return SomeNumbers%10;
}
if (number1 / 100 == 0)
{
    Console.WriteLine("No such number");
}
else
{
    Console.WriteLine(thirdNumber(number1));
}
