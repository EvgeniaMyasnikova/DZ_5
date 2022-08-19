/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] GetIntArray (int size)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}
int[] testArray = GetIntArray (size);
Console.WriteLine($"[{String.Join(",", testArray)}]");

// первый вариант

// int sum = 0;
// for (int i = 0; i < testArray.Length; i++)
// {
//     if (i % 2 == 1) sum = sum + testArray[i];
// }
// Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях, равна {sum}");

// Второй вариант

int i = 1;
int sum = 0;
while (i < testArray.Length)
{
    sum = sum + testArray[i];
    i+=2;
}
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях, равна {sum}");

