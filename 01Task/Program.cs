// Задать массив из 8 элементов и вывести их на экран

int[] Array = new int[8]{0,3,5,1,6,8,4,3};
for(int i = 0; i<Array.Length;i++)
{
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
double[] Array1 = new double[8];
for(int i = 0; i<Array1.Length; i++)
{
    Array1[i] = new Random().Next(0,100);
    Console.Write($"{Array1[i]} ");
}