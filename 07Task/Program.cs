// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

double[] Array = new double[123];
for(int i = 0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(0,1000);
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
double number = 0;
for(int i = 0; i < Array.Length; i++)
{
    if(Array[i]>=10 && Array[i]<=99) number++;
}
Console.WriteLine($"Количество элементов массива из отрезка от 10 до 99 - {number}");