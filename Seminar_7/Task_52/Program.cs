Console.Clear();
Console.Write("Введите количество строк(m) и столбцов(n) через пробел: ");
var s = Console.ReadLine()!.Split(" ");
Int32 m, n;
m = Convert.ToInt32(s[0]);
n = Convert.ToInt32(s[1]);
Random rand = new Random();
double[,] matrix = new double[m, n];
double[] summ = new double[m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = rand.Next(0, 10); 

    }
}
Console.WriteLine();
Console.WriteLine("Матрица");
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {

        Console.Write("{0,5}", matrix[i, j]); 
        summ[i] += matrix[j, i];      
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("--------------------");
foreach (double elem in summ)
{
    Console.Write("{0,5:f1}" ,elem / m); 
}


