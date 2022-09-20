// Написать функцию Sqrt(x) - квадратного корня, 
// которая принимает на вход целочисленное значение x и возвращает
//  целую часть квадратного корня от введенного числа.
Console.WriteLine(" Enter number: ");
int n = int.Parse(Console.ReadLine());
// standart operetion long and not effective)
int nsq(int num)
{
    int howManyOperation = 1;
    int result = 1;
    while(result*result<=num)
    {
        howManyOperation+=1;
        
        result+=1;
    }
    Console.WriteLine($" the count of opertions is: {howManyOperation}");
    return result-1;
}
Console.WriteLine(nsq(n));
// formula gerund is perfect!!!
int geron(int num)
{
    int operation = 1;
    int ger = (2 + num/2)/2;
    while(ger> (num/ger))
    {
        ger = (ger + num/ger)/2;     
        operation+=1;
    }
    Console.WriteLine($"  the count of opertions of formuls gerun is:  {operation}");
    return ger;
}
Console.WriteLine(geron(n));