Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int Max;
Max = a;   

if (b > a) {
  Max = b; 
  }
if (c > Max) {
    Max = c; 
    Console.Clear();
    }
    
    Console.WriteLine("Введённые числа: " + a + " " + b + " " + c);
    Console.WriteLine("Максимальным из трёх введённых чисел является: " + Max);