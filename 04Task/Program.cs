// Написать программу замену элементов массива на противоположные

double[] Array = new double[15];
for(int i = 0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(-50,51);
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
for(int i = 0; i<Array.Length; i++)
{
    Array[i] = -Array[i];
}
for(int i = 0; i<Array.Length; i++)
{
    Console.Write($"{Array[i]} ");
}