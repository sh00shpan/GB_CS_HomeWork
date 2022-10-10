/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
    
*/


int[] generateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}


void GetSumofNumberswithOddindexes(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
           result = result + array[i];
           //Console.WriteLine(i);
           //Console.WriteLine(array[i]);
        
        }

    }
    Console.WriteLine($"сумма элементов, стоящих на нечётных позициях составляет: {result}");
}

int[] currentArray = generateArray(6, -10, 10);
printArray(currentArray);
GetSumofNumberswithOddindexes(currentArray);

