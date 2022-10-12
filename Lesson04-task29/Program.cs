//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы задаются рандомно. Итоговый массив должен содержать в себе суммы цифр числа. Т.е. необходимо подсчитывать суммы цифр чисел и записывать их в новый массив.
int[] Massiv() {
    int kol = 8;
    int[] arr = new int [8];
    for (int i= 0; i<kol; i++) {
       arr[i] = new Random().Next(0, 100);
    }
    
    return arr;
}
 void Massiv2 (int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        int number = 0;
        int sum =0;
        while (arr[i]>0) {
            number = arr[i]%10;
            sum = sum + number;
            arr[i] = arr[i]/10;
        }
    Console.Write(" " + sum);    
}
 }
 
void Print(int[] arr) {
    Console.WriteLine(String.Join(" ", arr));
}
int [] arr = new int[8];
arr = Massiv();
Print (arr);
Massiv2(arr);
