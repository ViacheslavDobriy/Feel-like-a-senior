// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

double[] Array = new double[9];
for(int i = 0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(0,11);
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
for(int i = 0; i<Array.Length/2; i++)
{
    Console.WriteLine($"Произведение {i+1} пары чисел - {Array[i]*Array[Array.Length-1-i]}");
}