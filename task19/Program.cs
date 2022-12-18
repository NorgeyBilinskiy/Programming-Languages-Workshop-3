// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

try
{
    Console.WriteLine("Добрый день!");
    Console.WriteLine("Введите любое пятизначное число");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n<10000) Console.WriteLine("Вы ввели не пятизначное число");
    else if (n>99999) Console.WriteLine("Вы ввели не пятизначное число");
    else 
    {
        int first = n/10000;
        int second = n/1000;
        int fourth = n % 100;
        int fifth = n % 10;
        if ((first==fifth) || (second==fourth)) Console.WriteLine("Это число является палиндромом.");
        else Console.WriteLine("Это число НЕ является палиндромом.");
    }
}
catch {Console.WriteLine("Необходимо вводить целые числа: 56789, 100100 и т.д.");}