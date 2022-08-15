Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int sum = A;
for (int i = 1; i < B; i++)
{
    sum = sum *= A;
} Console.Clear();

Console.WriteLine(A + " в степени " + B + " = " + sum);