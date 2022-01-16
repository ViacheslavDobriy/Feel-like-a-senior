// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

double[] Array = new double[12];
for(int i = 0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(-9,10);
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
double SumPositive = 0;
for(int i = 0; i< Array.Length; i++)
{
    if(Array[i]>0)
    {
        SumPositive = SumPositive + Array[i];
    }
}
Console.WriteLine($"Сумма положительных чисел - {SumPositive}");
double SumNegative = 0;
for(int i = 0; i< Array.Length; i++)
{
    if(Array[i]<0)
    {
        SumNegative = SumNegative + Array[i];
    }
}
Console.WriteLine($"Сумма отрицательных чисел - {SumNegative}");