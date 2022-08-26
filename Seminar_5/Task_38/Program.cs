Random rnd = new Random();
int[] array = new int[12];
int max = 0, min = 100;
for (int i = 0; i < array.Length; i++) array[i] = rnd.Next(50);
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++) Console.Write("{0} " , array[i]);
Console.WriteLine();
Console.WriteLine("max:  " + max);
Console.WriteLine("min  " + min);
Console.WriteLine("Разница максимального и минимального:  " + (max - min));


