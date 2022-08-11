Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()) ;
int Max;

if(a > b) {
    Max = a;
    Console.WriteLine("Наибольшим является число " + Max);
}
if(a < b) {
    Max = b;
    Console.WriteLine("Наибольшим является число " + Max);
}