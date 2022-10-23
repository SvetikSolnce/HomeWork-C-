//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

for (int i = 0; i<m; i++) {
    double sum = 0;
    for (int j=0; j<n; j++) {
        sum = sum + matrix[j, i]; 
    }
    Console.WriteLine($"Среднее арифметическое {Math.Round(sum/n, 1)}");
}