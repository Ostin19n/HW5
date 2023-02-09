// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int SumNumber(int[] arrayList)
{
    int size = arrayList.Length;
    int SumNumbers = 0;
    for (int i = 1; i < size; i += 2)
    {
    SumNumbers += arrayList[i];
    }
    return SumNumbers;
}
   

int[] GetArray(int size, int min, int max)
{
    int[] arrayList = new int[size];
    for (int i = 0; i < size; i++)
       arrayList[i] = new Random().Next(min, max);
    return arrayList;
}


int[] arrayList = GetArray(4, -100, 101);

Console.WriteLine(String.Join(" " , arrayList));

int FindSumNumber = SumNumber(arrayList);



for (int n = 0; n < arrayList.Length; n++)
{
    if(n < arrayList.Length - 1)
        Console.Write($"{arrayList[n]}, ");
    else
        Console.Write($"{arrayList[n]}");
}
Console.WriteLine($" -> Сумма чисел на нечётных позициях: {FindSumNumber}");
