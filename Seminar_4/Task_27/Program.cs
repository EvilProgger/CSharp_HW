
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
int sum = 0;

for (i = 0; num > 0; i++) {
    sum = sum + num % 10;
    num = num /10 ;
}
Console.WriteLine("Сумма чисел в числе " + " равна " + sum);