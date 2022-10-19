//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] Massiv(int n) {
    int[] arr = new int [n];
    for (int i = 0; i<n; i++) {
       arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}
void Print(int[] arr) {
    Console.WriteLine(String.Join(" ", arr));
}
void kol (int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i]%2 == 0) count = count+1;
    }
     Console.WriteLine(count);     
}
int [] arr = new int[10];
arr = Massiv(10);
Print (arr);
kol(arr);
