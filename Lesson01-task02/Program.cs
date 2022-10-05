/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/

Console.WriteLine("Введите два числa:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a>b) {
    Console.WriteLine($"max={a}, min={b}");
}
else {
   Console.WriteLine($"max={b}, min={a}"); 
}

