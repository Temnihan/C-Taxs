int numerF = new Random().Next(1, 1000);
int numerS = new Random().Next(1, 1000);
Console.WriteLine($" {numerF}, {numerS}");
int num = numerF %numerS;
if (num ==0){
    Console.WriteLine("cool ");
}
else{
    Console.WriteLine("not coll");

}

Console.WriteLine($"{num}");
