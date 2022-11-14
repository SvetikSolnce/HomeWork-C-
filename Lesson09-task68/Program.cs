// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. С помощью рекурсии!!!
int A(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m > 0 && n == 0) return A(m - 1, 1);
        return A(m - 1, A(m, n - 1));
    }
    Console.Write("Введите число m: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число n: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(A(m, n));
        

