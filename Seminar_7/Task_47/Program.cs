Console.Clear();
Console.Write("Введите количество строк и столбцов через пробел: ");
var s = Console.ReadLine()!.Split(" ");
int m = Convert.ToInt32(s[0]);
int n = Convert.ToInt32(s[1]);
double[,] array = new double[m, n];
Random rnd = new Random();

CreateArray(array);
WriteArray(array);


void CreateArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100) / 10.0;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5:F2}" ,array[i, j] + " ");
        }
        Console.WriteLine();
    }
}