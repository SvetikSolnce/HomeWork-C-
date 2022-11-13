// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int n = 4;
int m = 4;
int num = 1;
int [,] array = new int [m,n];
for (int j=0; j<n; j++) {
    array [0,j] = num;
    num = num + 1;
}
for (int i=1; i<m; i++){
    array [i, n-1] = num;
     num = num + 1;
}
for (int j=n-2; j>=0; j--) {
    array[m-1, j] = num;
    num = num + 1;
}
for (int i=m-2; i>0; i--) {
    array [i, 0] = num;
    num = num + 1;
}
int num1 = 1;
int num2 = 1;
while (num < m*n) {
    while(array[num1, num2 + 1] == 0) {
        array[num1, num2] = num;
        num = num + 1;
        num2 = num2 + 1;
    }
    while(array[num1 + 1, num2] == 0) {
        array[num1, num2] = num;
        num = num + 1;
        num1 = num1 + 1;
    }
    while(array[num1, num2 - 1] == 0) {
        array[num1, num2] = num;
        num = num + 1;
        num2 = num2 - 1;
    }
    while(array[num1 - 1, num2] == 0) {
        array[num1, num2] = num;
        num = num + 1;
        num1 = num1 - 1;
    }
}
for (int i=0; i<m; i++) {
    for (int j=0; j<n; j++) {
        if (array [i,j] ==0) {
            array [i,j] =num;
        }
    }
}

void PrintArray(int[,] arr) {
    for (int i = 0; i<arr.GetLength(0); i++) {
    for (int j=0; j<arr.GetLength(1); j++) {
        if (arr[i,j] < 10) {
            Console.Write($"0{arr[i, j]} ");
        }
        else {
            Console.Write($"{arr[i, j]} ");
        }
        
    }
    Console.WriteLine();
    }
}
PrintArray(array);