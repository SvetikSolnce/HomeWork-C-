// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray(int[,] arr) {
    for (int i = 0; i<arr.GetLength(0); i++) {
    for (int j=0; j<arr.GetLength(1); j++) {
       arr[i,j] = new Random().Next(1, 10);
    }
    }
}

void PrintArray(int[,] arr) {
    for (int i = 0; i<arr.GetLength(0); i++) {
    for (int j=0; j<arr.GetLength(1); j++) {
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
    }
}

void SortArray(int[,] arr) {
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(1) - 1; k++)
      {
        if (arr[i, k] < arr[i, k + 1])
        {
          int temp = arr[i, k + 1];
          arr[i, k + 1] = arr[i, k];
          arr[i, k] = temp;
        }
      }
    }
  }
}
int[,] array = new int [5, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);
