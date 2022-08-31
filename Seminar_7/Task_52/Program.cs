Console.Clear();
Console.Write("Введите количество строк и столбцов через пробел: ");
var s = Console.ReadLine()!.Split(" ");
int m = Convert.ToInt32(s[0]);
int n = Convert.ToInt32(s[1]);
Random rand = new Random();
double[,] matrix = new double[m, n];
double[] summ = new double[n];
CreateArray(matrix);
Console.WriteLine();
Console.WriteLine("Матрица");
Console.WriteLine();

WriteArray(matrix);

Console.WriteLine();
Console.WriteLine("--------------------");
foreach (double elem in summ)
{
    Console.Write("{0,5:f2}, /" ,elem / m); 
    
}

void CreateArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 21);
        }
    }
}

void WriteArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
            summ[j] += matrix[i, j];
        }
        Console.WriteLine();
    }
}