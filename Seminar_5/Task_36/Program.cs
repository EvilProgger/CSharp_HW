int[] array = new int[8];
int N = 0;
int sum = 0;
Random rnd = new Random();

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);
    Console.Write("{0} ", array[i]);
}

foreach (int element in array)
{
    
    if (element % 2 != 0)
    {
        N++;
        sum = sum + N;
    }
}
Console.WriteLine();
Console.WriteLine("Количество нечётных чисел: " + N);
Console.WriteLine("Сумма нечётных чисел: " + sum);