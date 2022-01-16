// Определить, присутствует ли в заданном массиве, некоторое число

double[] Array = new double[100];
for(int i = 0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(0,100);
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
Console.WriteLine("Введите число, которое нужно найти в массиве: ");
double UserNumber = Convert.ToInt32(Console.ReadLine());
bool check = true;
for(int i = 0; i< Array.Length && check ==true; i++)
{
    if(Array[i]==UserNumber) check = false;
}
if(check==true) Console.WriteLine($"{UserNumber} нет в данном массиве");
else
{
    Console.WriteLine($"{UserNumber} есть в массиве");
}