//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

void Matrix(int [,] arr1, int[,] arr2, int [,] arr) {
    for (int i=0; i<arr.GetLength(0); i++)
    for (int j=0; j<arr.GetLength(1); j++) {
        int sum = 0;
        for (int k=0; k<arr1.GetLength(1); k++) {
            sum = sum + arr1[i,k]*arr2[k,j];
        }
        arr [i,j] = sum;
    }
}

int[,] array1 = new int [5, 5];
int[,] array2 = new int [5, 5];
int[,] array = new int [5,5];
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();
Matrix(array1, array2, array);
PrintArray(array);


