// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. С помощью рекурсии!!!
int FillNumbers (int m, int n) {
    int sum = 0;
    if (n==m) return n ;
    else
        return (sum + (m + FillNumbers(m+1, n)));
}
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(FillNumbers(m,n));