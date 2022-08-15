 Console.Write("Введите размер массива: ");
 int n = Convert.ToInt32(Console.ReadLine());
string[] strs = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите строку №{0}:\n\r    ", i + 1);
    strs[i] = Console.ReadLine();
}
Console.WriteLine("Получившийся массив:");
for (int i = 0; i < n; i++)
{
    Console.WriteLine("[{0}]", strs[i]);
}