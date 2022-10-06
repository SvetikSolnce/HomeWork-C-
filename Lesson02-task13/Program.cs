// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число:");
string? str = Console.ReadLine();
char[] array = new char[str.Length];
if (str.Length < 3)  Console.WriteLine("Третьей цифры нет");
else {
    for (int i = 0; i < str.Length; i++) {
    array[i] = str[i];  
    }
Console.WriteLine(array[2]);
}


