// Найти сумму чисел одномерного массива стоящих на нечетной позиции

double[] Array = new double[20];
for(int i = 0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(1,11);
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
double sum = 0;
for(int i = 1; i<Array.Length; i++)
{
    if(i%2!=0)sum = sum + Array[i];
}
Console.WriteLine($"Сумма элементов с нечетными номерами - {sum}");