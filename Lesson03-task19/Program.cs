// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int Palindrome(int num) {
    int n = num;
    int l = 0;
    int pal = 0;
    while (n > 0) {
    l = n % 10;
    pal = pal * 10 + l;
    n = n / 10; 
    }
    return pal;
}
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int Palindrom = Palindrome(num);
Console.WriteLine(Palindrom);
if (num == Palindrom) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");

 