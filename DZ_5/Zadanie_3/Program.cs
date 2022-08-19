/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] GetDoubleArray (int size)
{
    double[] result = new double[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] =  new Random(). NextDouble()*100;
    }
    return result;
}
double[] testArray = GetDoubleArray (size);
Console.WriteLine($"[{String.Join("  ", testArray)}]");

double max = testArray[0];
double min = testArray[0];
for (int i = 0; i < testArray.Length; i++)
{
    if (testArray[i] > max) max = testArray[i];
    if (testArray[i] < min) min = testArray[i];
}
double result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом = {result}");

 

