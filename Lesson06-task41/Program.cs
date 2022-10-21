//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите числа через запятую:");
int[] m = Console.ReadLine().Split(',').Select(e => Convert.ToInt32(e)).ToArray();
void Summa (int[] m) {
    int count = 0;
    for (int i=0; i<m.Length; i++) {
        if (m[i]>0) count = count + 1;
    }
    Console.WriteLine(count);    
}
void Print(int [] m) {
    Console.WriteLine(String.Join(" ", m));
}
Print(m);
Summa(m);



