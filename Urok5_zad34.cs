/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

if (number % 2 == 0)

    Console.WriteLine("Число кратно двум");
    
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


void countEvenNumbersInArray(int[] array)
{
    int evenCounter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]% 2 == 0)
        {
            evenCounter +=1;
        }

    }
    Console.WriteLine($"Количество четных числе в массиве составляет: {evenCounter}");
}

int[] currentArray = generateArray(9, 100, 999);
printArray(currentArray);
countEvenNumbersInArray(currentArray);

