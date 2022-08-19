// Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b)
//  и выводит их на экран.
//  Я ТАК ПОНЯЛ ЧТО НУЖНО ВВЕСТИ 3 ЦИФРЫ:
// 1-АЯ  ЭТО КОЛ ВО ЭЛЕМЕТНОВ
// 2-АЯ ЭТО ОТ СКОЛЬКИ 
// 3 -Я ДО СКОЛЬКИ
// ИСХОДЯ ИЗ ЭТОГО РЕШАЮ ЗАДАЧУ НИЖЕ
Console.WriteLine("Enter size massive: ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Enter start Random: ");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Enter End Random: ");
int end = int.Parse(Console.ReadLine());
int []arr  = new  int[size];
void RandArray(int Size, int Start, int End){
    for( int i = 0; i <arr.Length; i++){
        arr[i] = new Random().Next(Start,End);
        // первый способ вывода
         Console.Write("{0} ",arr[i]);
    }
    // второй способ вывода
    Console.WriteLine($"[{String.Join(",",arr)}]");
}
RandArray( size,start,end);