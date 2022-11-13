// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray(int[, ,] arr) {
    for (int i = 0; i<arr.GetLength(0); i++) {
        for (int j=0; j<arr.GetLength(1); j++) {
            for (int k=0; k<arr.GetLength(2); k++) {
                arr[i,j,k] = new Random().Next(10, 100);   
            }

       
        }
    }
}

void PrintArray(int[, ,] arr) {
    for (int i = 0; i<arr.GetLength(0); i++) {
        for (int j=0; j<arr.GetLength(1); j++) {
           for (int k=0; k<arr.GetLength(2); k++) {
            Console.Write($"{arr[i, j, k]} ({i},{j},{k})  ");
           } 
           Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[, ,] array = new int [2,2,2];
FillArray(array);
PrintArray(array);