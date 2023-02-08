﻿// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double MinMax (double[] array)
{
    double size = array.Length;
    double max = 0;
    double min = 0;
    double difference = max - min;
    for (int z = 0; z < array.Length; z++)
{
    if (array[z] > max)
        {
            max = array[z];
        }
    if (array[z] < min)
        {
            min = array[z];
        }
}
    return difference;
}

double[] GetArray(double size, double min, double max)
{
    double[] emptyArray = new double [size];
    for(double i = 0; i < size; i++)
    {
        emptyArray[i] = new Random().Next(min, max);

    }
    return emptyArray;
}


// генерируем массив
double [] array = GetArray(4, 0, 99);

Console.WriteLine(String.Join(" " , array));

double FindMinMax = MinMax(array);

Console.WriteLine($"Разница между максимальным и минимальным значением = {MinMax}");