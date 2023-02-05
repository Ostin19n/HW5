// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int SearchEven(int[] array, bool positive)
{
    int even = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if(array[i]%2==0)
        {
            even = even + 1;

        }
    }
    return even;
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
int[] array = GetArray(4, 100, 999);

Console.WriteLine(String.Join(" " , array));

// количество четных чисел
int evenNumber = SearchEven(array, true);

Console.WriteLine($"Количество четных чисел = {evenNumber}");