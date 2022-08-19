//  Напишите функцию и запустите ее, которая принимает на вход число 
//  и выдаёт сумму цифр в числе.
int sumAllNumbers(int number)
{

    int sum = number % 10;
    while (number > 9)
    {
        number = number / 10;
        sum += number % 10;
    }
    return sum;
}
Console.WriteLine("Enter Nuber: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(sumAllNumbers(N));