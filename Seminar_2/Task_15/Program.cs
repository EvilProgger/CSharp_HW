Console.Write("Введите число дня недели: ");
int number =  Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Введённый день недели: " + number);
if(number <= 7 & number >= 1) {
    if(number <= 5 & number >=1) {
        Console.Write("НЕ является выходным ");
    }
    if( number == 1) {
        Console.WriteLine("Понедельник");
    }
    if(number == 2) {
        Console.WriteLine("Вторник");
    }
    if(number == 3) {
        Console.WriteLine("Среда");
    }
    if(number == 4) {
        Console.WriteLine("четверг");
    }
    if(number == 5) {
        Console.WriteLine("Пятница");
    }
    if(number >= 6 | number >= 7) {
        Console.Write(" Выходной ");
    }
    if(number == 6) {
        Console.Write("Суббота");
    }
    if(number == 7) {
        Console.Write("Воскресенье");
    }

    }
    else {
        Console.WriteLine("Такого дня недели не существует");
    }
