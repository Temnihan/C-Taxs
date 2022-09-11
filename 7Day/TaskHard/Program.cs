// Написать программу для перевода римских чисел в десятичные арабские.
Console.WriteLine("Enter :");
string str = Console.ReadLine();
char[] characters = str.ToCharArray();
// Console.WriteLine(characters[2]);
// 1.  ---- change char to numbers  ------
int[] RomeArray(char[] rome)
{
    int v = 0; // v,l d   не должны повторяться
    int l = 0;
    int d = 0;
    // I X C M  не могут повторятся более 3 раз подряд
    int I = 0;
    int X = 0;
    int C = 0;
    int M = 0;

    int[] romoArr = new int[rome.Length];
    for (int i = 0; i < rome.Length; i++)
    { 
        switch (rome[i])
        {
            case 'I':
                romoArr[i] = 1;
                I+=1; X = 0; C = 0; M = 0;
                break;
            case 'V':
                romoArr[i] = 5;
                v += 1;
                I=0; X = 0; C = 0; M = 0;
                break;
            case 'X':
                romoArr[i] = 10;
                X+=1; I = 0; C = 0; M = 0;
                break;
            case 'L':
                romoArr[i] = 50;
                l += 1;
                I=0; X = 0; C = 0; M = 0;
                break;
            case 'C':
                romoArr[i] = 100;
                C+=1; I = 0; X = 0; M = 0;
                break;
            case 'D':
                romoArr[i] = 500;
                d += 1;
                I=0; X = 0; C = 0; M = 0;
                break;
            case 'M':
                romoArr[i] = 1000;
                M+=1; I = 0; C = 0; X = 0;
                break;
            default:
                d += 2;
                break;
        }
        if (I >3 || C>3 || M>3 || X>3)
        {  return new int[] {0};}
        if ( i>0 )
        { if ( romoArr[i]> romoArr[i-1] & romoArr[i-1]!=0){
            romoArr[i-1] = romoArr[i] - romoArr[i-1];
            romoArr[i] = 0;}
        }
    }
    if (v > 1 || l > 1 || d > 1)
        { return new int[] {0 };}
    return romoArr;
}
int [] myArray = RomeArray(characters);

// Console.WriteLine(string.Join(" ", myArray));
int RomNumber(int[] array){
    int sum =0;
    int tmp = array[0];
    if (array.Length<2) { return tmp;};
    for (int i = 0; i < array.Length; i++)
    {

        sum+= array[i];
    }

    return sum;
}
Console.WriteLine($"convert is {RomNumber(myArray)}");