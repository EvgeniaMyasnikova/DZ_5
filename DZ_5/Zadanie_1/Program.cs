/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] GetIntArray (int size)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}
int[] testArray = GetIntArray (size);
Console.WriteLine($"[{String.Join(",", testArray)}]");

int evenCount = 0;
int oddCount = 0;
for (int i = 0; i < testArray.Length; i++)
{
    if (testArray[i] % 2 == 0) evenCount ++;
    if (testArray[i] % 2 == 1) oddCount ++;
}    
Console.WriteLine($"Количество четных чисел равно {evenCount}");
Console.WriteLine($"Количество нечетных чисел равно {oddCount}");
