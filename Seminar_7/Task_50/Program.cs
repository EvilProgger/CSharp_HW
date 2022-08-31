Console.Clear();
Console.Write("Введите количество строк и столбцов через пробел: ");
var s = Console.ReadLine()!.Split(" ");
int m = Convert.ToInt32(s[0]);
int n = Convert.ToInt32(s[1]);
int[,] array = new int[m, n];

CreateArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}

Console.WriteLine("Введите координаты через пробел: ");
var ab = Console.ReadLine()!.Split(" ");
int a = Convert.ToInt32(ab[0]);
int b = Convert.ToInt32(ab[1]);

if (a >= m & b >= n) {
    Console.WriteLine("Такого числа нет");
 }
else {
    object c = array.GetValue(a, b)!;
    Console.WriteLine(c);
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 21);
        }
    }
}