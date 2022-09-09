Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N: ");
int M = Convert.ToInt32(Console.ReadLine());

string Queue(int n)
{
    string result = String.Empty;
    if (n == 0) return "";
    else return $"{n}, {Queue(n - 1)}";
}
Console.WriteLine(Queue(n));



