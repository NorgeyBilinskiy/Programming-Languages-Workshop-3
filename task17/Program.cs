// Напишите программу, которая принимает на вход координаты точек (X и Y), причём X и Y не равны нулю, и выдаёт номер четверти плоскости, 
// в которой находится эта точка

// Функции программы
void CheckKoord(int x, int y)
{
    if (x>0 && y>0) Console.WriteLine("Эта четверть №1");
    else if (x<0 && y>0) Console.WriteLine("Эта четверть №2");
    else if (x<0 && y<0) Console.WriteLine("Эта четверть №3");
    else if (x>0 && y<0) Console.WriteLine("Эта четверть №4");
    else Console.WriteLine ("Точка находится на координатной оси");
}

// Тело программы
try
{
Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());
CheckKoord(x,y); 
}
catch 
{
Console.WriteLine("Необходимо вводить целые числа: -1, -2, 1, 2 и т.д.");
}



