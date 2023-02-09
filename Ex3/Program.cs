// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 7


double [] DoubleArray(int min, int max, int size)   
{                                                   
    Random random = new Random();                   
    double[] array = new double [size];                  
                                                    
    for (var i = 0; i < array.Length; i++)          
    {
        array[i] = random.NextDouble();       
    }
    return array;                                  
} 


void PrintArray(double[] array)                       
{
     Console.WriteLine(@"[{0}]", string.Join("; ", array)); 
}                                         


void GetDifference(double [] array)   
{                                                   
    double min = array[0];
    double max = array[0];
    double diff = 0;
                                                  
    for (var i = 0; i < array.Length; i++)          
    {
       if (array[i] > max)
          {
            max = array[i];
          }
         
            if (array[i] < min)
           {
                min = array[i];
           }
    }
    diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным значением = {diff}.");
}

double[] array = DoubleArray(199,108,4);              
                                                   
PrintArray(array);                                

GetDifference(array);
