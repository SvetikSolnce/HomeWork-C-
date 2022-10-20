// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] Massiv(int n) {
    double [] arr = new double [n];
    for (int i = 0; i<n; i++) {
       arr[i] = new Random().Next(0, 100) + new Random().NextDouble() ;
    }
    return arr;
}
void Print(double [] arr) {
    Console.WriteLine(String.Join(" ", arr));
}
double Max (double[] arr) {
    double max = arr[0];
    for (int i = 0; i<arr.Length; i++) {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}
double Min (double[] arr) {
    double min = arr[0];
    for (int i = 0; i<arr.Length; i++) {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}
double [] arr = new double [10];
arr = Massiv(10);
Print (arr);
Max (arr);
double minimum = Min(arr);
double maximum = Max(arr);
Console.WriteLine($"максимальное число: {maximum}");
Console.WriteLine($"минимальное число: {minimum}");
Console.WriteLine($"Разница:{maximum - minimum}");






