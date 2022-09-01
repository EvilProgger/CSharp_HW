Console.Clear();
Console.Write("Введите размерность массива (уровни, строки, столбцы) через пробел: ");
var s = Console.ReadLine()!.Split(" ");
Console.WriteLine();

int x = Convert.ToInt32(s[0]);
int y = Convert.ToInt32(s[1]);
int z = Convert.ToInt32(s[2]);

double[,,] array3D = new double[x, y, z];
CreateArray(array3D);
WriteArray(array3D);
Console.WriteLine("Построение трёхмерного массива завершено!");



void CreateArray(double[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = new Random().Next(-10, 100) + new Random().Next(1, 2);
            }
        }
    }
}

void WriteArray(double[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine("Уровень № " + (i + 1));

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"[{matrix[i, j, k]}]" + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}