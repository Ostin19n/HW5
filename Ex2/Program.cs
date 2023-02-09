// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] array = GetArray(-10,10,4);              
                                                   
PrintArray(array);                                

int sum = SumElementsOddIndexes(array);

Console.WriteLine($"Сумма элементов = {sum}.");




int[] GetArray(int min, int max, int size)   
{                                                   
    Random random = new Random();                   
    int[] array = new int [size];                  
                                                    
    for (var i = 0; i < array.Length; i++)          
    {
        array[i] = random.Next(min, max + 1);       
    }
    return array;                                  
} 


void PrintArray(int[] array)                       
{
     Console.WriteLine(@"[{0}]", string.Join(",", array)); 
}                                         


int SumElementsOddIndexes(int[] array)
{
    int sum = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = array[i] + sum ;
        }
    }
    return sum;
}