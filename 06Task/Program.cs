// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

double[] Array = new double[20];
for(int i = 0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(100,1000);
    Console.Write($"{Array[i]} ");
}
int countEven = 0;
int countNotEven = 0;
for(int i = 0; i< Array.Length; i++)
{
    if(Array[i]%2==0) countEven++;
    else countNotEven++;
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел - {countEven}");
Console.WriteLine($"Количество нечетных чисел - {countNotEven}");