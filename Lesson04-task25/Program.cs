// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.

void fun (int A, int B) {
    double stepen = 1;
    if (A>0 && B>0) {
        stepen = Math.Pow(A, B);
        Console.WriteLine($"Степень числа: {stepen}");
    }
    else Console.WriteLine("Введите положительные числа");
}
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
fun(A, B);

