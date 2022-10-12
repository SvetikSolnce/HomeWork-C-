// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("ВВедите число:");
int n = int.Parse(Console.ReadLine());
int number = 0;
int sum = 0;
while (n>0) {
    number = n%10;
    sum = sum + number;
    n = n/10;
}
Console.WriteLine(sum);
