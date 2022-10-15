/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GenerateArray(int height, int weight, int deviation)
{
    int[,] generatedArray = new int[height,weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i,j] = new Random().Next(deviation, deviation+10);
        }
    }
    return generatedArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] inputArray)

{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j].ToString()}\t");
        }
        Console.WriteLine();
    }
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

int [] GetSumofRowsArray (int[,] inputArray)
{    
    int TempColumnSumResult = 0;
    int[] ColumnsSumResultsArray = new int [inputArray.GetLength(0)];

    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < inputArray.GetLength(0); j++)
        {
            for (int z = i; z < inputArray.GetLength(1); z++)
            {
                //Console.WriteLine($"i {i}, j {j}, z{z}");
                //Console.WriteLine($"Элемент {inputArray[j,z]}");
                TempColumnSumResult+=inputArray[j,z];
            }
            //Console.WriteLine($"Строка {j} Сумма элементов {TempColumnSumResult}");
            //printArray(ColumnsSumResultsArray);
            ColumnsSumResultsArray[j]=TempColumnSumResult;
            TempColumnSumResult=0;
        }
    }
    return ColumnsSumResultsArray;
}

void GetMinNumberinArray (int[] ArrayToSearch)
{
    int minNumber = 999;
    int minIndex = -1;
    for (int i = 0; i < ArrayToSearch.Length; i++)
    {
        if (ArrayToSearch[i] < minNumber)
        {
            minNumber = ArrayToSearch[i];
            minIndex = i;
        }
    }

    Console.WriteLine($"Минимальная сумма элементов {minNumber} в строке №{minIndex}");
}


int[,] generatedArray = GenerateArray(5,3,1);
print2DArray(generatedArray);
int[] SumOfRowsArray = GetSumofRowsArray (generatedArray);

Console.WriteLine("[Массив с суммами чисел в строках]");
printArray(SumOfRowsArray);
GetMinNumberinArray(SumOfRowsArray);