/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

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

void showArray(int[,] inputArray)

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

int [,] RowsSortFromLowToHighNumbers(int[,] inputArray)
{
    //Console.WriteLine($"Dlina Stroki (1): {inputArray.GetLength(1)}");
    //Console.WriteLine($"Dlina Column (0): {inputArray.GetLength(0)}");
    
    int temp = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int z = j+1; z < inputArray.GetLength(1); z++)
            {
                if (inputArray[i,j] < inputArray[i,z])
                {
                    temp = inputArray[i,j];
                    inputArray[i,j] = inputArray[i,z];
                    inputArray[i,z] = temp;
                }
            }
        }
    }
    return inputArray;
}


int[,] generatedArray = GenerateArray(4,4,1);

Console.WriteLine("Исходный массив");
showArray(generatedArray);
int[,] SortedRowsArray = RowsSortFromLowToHighNumbers(generatedArray);

Console.WriteLine("Преобразованный массив с сортировкой строк по убыванию");
showArray(SortedRowsArray);
