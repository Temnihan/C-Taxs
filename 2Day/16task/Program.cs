int numer1 = new Random().Next(1, 10);
Console.WriteLine(numer1);
int number2 = int.Parse(Console.ReadLine());
if (numer1 > number2)
{
    //Console.WriteLine("cool");
    (number2, numer1) = (numer1, number2);
}
if ( numer1 *numer1 == number2){
    Console.WriteLine("cool");
}
