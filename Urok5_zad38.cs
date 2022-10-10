/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


float[] generateArray(int length, int start, int end)
{
    float[] array = new float[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void printArray(float[] incomingArray)
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

float getMaxNumberInArray(float[] array)
{
    float maxNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    Console.WriteLine($"Макс число массива {maxNumber}");
    return maxNumber;
}

float getMinNumberInArray(float[] array)
{
    float minNumber = 999;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    Console.WriteLine($"Мин число массива {minNumber}");
    return minNumber;
}

float[] currentArray = generateArray(9, 1, 99);
printArray(currentArray);
//getMinNumberInArray(currentArray);
//getMaxNumberInArray(currentArray);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива составляет {getMaxNumberInArray(currentArray)-getMinNumberInArray(currentArray)}");
