//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
string FillNumbers (int n) {
    if (n==1) return "1";
    else
        return (n + " " + FillNumbers(n-1));
}
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"N = {num} -> {FillNumbers(num)}");