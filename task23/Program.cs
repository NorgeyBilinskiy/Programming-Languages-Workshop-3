// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Добрый день!");
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
if (n<0) n=-n;
if (n== 0) Console.WriteLine("0 в любой степни равняется 0");
else 
{
    Console.WriteLine("Таблица кубов до числа " + n + ":");
    for(int i = 1; i<=n; i ++)
    {
        int cube = (i*i*i);
        Console.WriteLine(i + " в кубе равняется " + cube);
    }
}

