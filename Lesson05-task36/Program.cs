// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] Massiv(int n) {
    int[] arr = new int [n];
    for (int i = 0; i<n; i++) {
       arr[i] = new Random().Next(-100, 100);
    }
    return arr;
}
void Print(int[] arr) {
    Console.WriteLine(String.Join(" ", arr));
}
void summma (int[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (i%2!=0) sum = sum + arr[i];
    }
Console.WriteLine(sum);        
}
int [] arr = new int[10];
arr = Massiv(10);
Print (arr);
summma(arr);
