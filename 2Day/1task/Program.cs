int numerR = new Random().Next(10,99);
Console.WriteLine(numerR);
int m = numerR %10;
int a2 = numerR/10;
if (a2> m){
    m = a2;
}
Console.WriteLine(m);