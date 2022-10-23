//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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
