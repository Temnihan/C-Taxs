// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена
Console.Write(" Enter string: ");
string s= Console.ReadLine();
Console.WriteLine(s);
string fBrackets(string s)
{
    int count1 = 0;
    int count2 = 0;
    int count3 = 0;
    for (int i = 0; i < s.Length; i++)
    {   
        switch (s[i])
        {
            case '(':
            count1 ++;
            break;
            case ')':
            count1 --;
            break;
            case '[':
            count2 ++;
            break;
            case ']':
            count2 --;
            break;
            case '{':
            count3 ++;
            break;
            case '}':
            count3 --;
            break;
        }
    }
    if (count1 == 0 & count2 == 0 & count3 == 0) return "write";
    else return "wrong";
}
// Console.Writeline(fBrackets(s));
Console.WriteLine(fBrackets(s));