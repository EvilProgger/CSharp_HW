int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return Akkerman(M - 1, Akkerman(M, N - 1));
    }
}


int M = InputNumber("Введите M: ");
int N = InputNumber("Введите N: ");
int akkermanFunction = Akkerman(M, N);
Console.Write($"m = {M}, n = {N} - > A(m,n) = {akkermanFunction} ");