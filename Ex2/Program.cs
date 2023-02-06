﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int SumOddNum(int[] array)
{   
    int size = array.Length;
    int result = 0;
    for (int i = 1; i < size; ++i)
    {
        if (array[i] % 2 == 0)
        {
            result += array[i];
        }
        
     }
    return result;
}


int[] GetArray(int size, int start, int finish)
{
    int [] emptyArray = new int[size];
    for(int index = 0; index < size; index++)
    {
        emptyArray[index] = new Random().Next(start, finish+1);

    }
    return emptyArray;
}


// генерируем массив
int[] array = GetArray(4, -100, 100);

Console.WriteLine(String.Join(" " , array));

// сумма  чисел
int SumNum = SumOddNum(array);

Console.Write($"Сумма элементов -> {SumNum}");