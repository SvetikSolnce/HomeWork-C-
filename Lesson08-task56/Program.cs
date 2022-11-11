// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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


int[,] array = new int [5, 5];
FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++) {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++) {
        sum = sum + array[i, j];
    }
    Console.Write(sum + " ");
}

int SumElement(int[,] array, int i)
{
  int sumEl = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumEl = sumEl + array[i,j];
  }
  return sumEl;
}

int minSum = 0;
int sumEl = SumElement(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumElement(array, i);
  if (sumEl > temp)
  {
    sumEl = temp;
    minSum = i;
  }
}

Console.WriteLine($"\n наименьшей суммой элементов {minSum+1} - строкa");

