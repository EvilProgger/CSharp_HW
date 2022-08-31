Console.Clear();
Console.Write("Введите количество строк и столбцов для первой матрицы через пробел: ");
var s = Console.ReadLine()!.Split(" ");
Int32 m, n;

Console.Write("Введите количество строк и столбцов для второй матрицы через пробел: ");
var q = Console.ReadLine()!.Split(" ");
Int32 p;

m = Convert.ToInt32(s[0]);
n = Convert.ToInt32(s[1]);
p = Convert.ToInt32(q[0]);

int[,] firstMatrix = new int[m, n];
CreateArray(firstMatrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
CreateArray(secondMatrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secondMatrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}