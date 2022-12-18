// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Добрый день!");
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
if (n<0) n=-n;
Console.WriteLine("Таблица кубов до числа " + n + ":");
