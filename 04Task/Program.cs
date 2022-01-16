// Написать программу замену элементов массива на противоположные

double[] Array = new double[15];
for(int i = 0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(0,51);
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
double Remember = 0;
for(int i = 0; i<=Array.Length/2; i++)
{
    Remember = Array[i];
    Array[i] = Array[Array.Length-1-i];
    Array[Array.Length-1-i] = Remember;
}
for(int i = 0; i<Array.Length; i++)
{
    Console.Write($"{Array[i]} ");
}