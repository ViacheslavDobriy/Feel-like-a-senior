// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

double[] Array = new double[8];
for(int i = 0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(0,2);
    Console.Write($"{Array[i]} ");
}
