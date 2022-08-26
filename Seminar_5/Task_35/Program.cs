// НЕ МОГУ ПРИДУМАТЬ ПРАВИЛЬНОЕ РЕШЕНИЕ ВЫВОДА ЭЛЕМЕНТОВ ИЗ ОТРЕЗКА[10, 99] (Выводится только одно число)
int[] array = new int[123];
int N = 0;
int i = 0;
Random rnd = new Random();

Console.WriteLine("Исходный массив: ");

void arrayinteger() {
     for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 124);
    Console.Write("{0} ", array[i]);
}
}

void arrayvalue() {
    if (array[i] > 10 && array[i] < 100) {
    N = N + array[i];
     Console.WriteLine(N);
    } 
    else
    {
        Console.WriteLine("таких элементов нет в массиве");
    } 
} 

arrayinteger();
arrayvalue();



