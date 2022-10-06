// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру от 1 до 7:");
int num = int.Parse(Console.ReadLine());
if (num == 6) Console.WriteLine("ДА");
else if (num == 7) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");

