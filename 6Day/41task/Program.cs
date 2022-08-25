// Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.WriteLine("Enter size Array");
int num = int.Parse(Console.ReadLine());
int  ElementsMoreZero( int m){
    int result = 0;
    for (int i = 0; i < m; i++)
    {
        if ( int.Parse(Console.ReadLine())>0) result++;
    }
    return result;
}
Console.WriteLine($" elem more 0 is: {ElementsMoreZero(num)}");