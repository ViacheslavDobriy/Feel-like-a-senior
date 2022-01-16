// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] Array = new double[8]{9,1,13,5,7,3,76,32};
for(int i = 0; i<Array.Length; i++)
{
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
double max = Array[0];
for(int i = 1; i<Array.Length; i++)
{
    if(Array[i]>max) max=Array[i];
}
Console.WriteLine($"{max} - максимальное значение в данном массиве");
double min = Array[0];
for(int i = 1; i<Array.Length; i++)
{
    if(Array[i]<min) min=Array[i];
}
Console.WriteLine($"{min} - минимальное значение в данном массиве");