Console.Clear();
Console.Write("Введите количество строк(m) и столбцов(n) через пробел: ");
var s = Console.ReadLine()!.Split(" ");
Int32 m, n;
m = Convert.ToInt32(s[0]);
n = Convert.ToInt32(s[1]);
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}

Console.WriteLine("Введите координаты через пробел: ");
var ab = Console.ReadLine()!.Split(" ");
Int32 a, b;
a = Convert.ToInt32(ab[1]); 
b = Convert.ToInt32(ab[0]);
if (a > m && b > n)
    Console.WriteLine("Такого числа нет");
else
{
    object c = array.GetValue(a, b)!;
    Console.WriteLine(c);
}