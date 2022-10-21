//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите точки b1, k1, b2, k2:");
int b1 = int.Parse(Console.ReadLine());
int k1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());
double x = (double) (b2-b1)/(k1-k2);
double y = (double) k1*x + b1;
Console.WriteLine($"({x};{y})");