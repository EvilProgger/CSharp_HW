Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введённое число: " + N);
for(int i = 1; i <= N; i++) {
    Console.WriteLine(i + "\t" + i*i*i);
}

