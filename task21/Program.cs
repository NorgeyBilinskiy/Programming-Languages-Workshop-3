// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Добрый день!");
Console.WriteLine("Введите первую координату X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату Y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату Z");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату X");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату Y");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату Z");
int z2 = Convert.ToInt32(Console.ReadLine());
double lenght = Math.Sqrt(Math.Pow((x2 - x1), 2)+Math.Pow((y2 - y1), 2)+Math.Pow((z2 - z1), 2));
lenght = Math.Round(lenght,1,MidpointRounding.AwayFromZero);
Console.WriteLine("Длина между данными точками в 3D пространстве равняется " + lenght);