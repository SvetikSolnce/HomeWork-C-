//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void PrintArray(int[,] matr) {
    for (int i = 0; i<matr.GetLength(0); i++) {
    for (int j=0; j<matr.GetLength(1); j++) {
        Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
    }
}
void FillArray(int[,] matr) {
    for (int i = 0; i<matr.GetLength(0); i++) {
    for (int j=0; j<matr.GetLength(1); j++) {
        matr[i,j] = new Random().Next(1, 10);
    }
    }
}
Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите m:");
int m = int.Parse(Console.ReadLine());
int[,] matrix = new int [n, m];
FillArray(matrix);
PrintArray(matrix);
Console.Write("Введите i:");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите j:");
int j = int.Parse(Console.ReadLine());
if (i>n && j>m) 
    Console.WriteLine(" такого числа в массиве нет");
else
    Console.WriteLine(matrix[i,j]);

