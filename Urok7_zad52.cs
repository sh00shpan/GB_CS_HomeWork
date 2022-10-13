/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] generate2DArray(int hight, int width, int randomStart, int randomEnd)
{
    int[,] twoDarray = new int[hight,width];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDarray[i,j] = new Random().Next(randomStart, randomEnd+1);
        }
        
    }
    return twoDarray;
}

void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void SredneeArifmetStolbzov(int[,] inputArray)
{
    int  summ = 0;
    int SredneeArifmetStolbza = 0;
    int ColumnNumber = 0;
    for (int i = 0; i < inputArray.GetLength(1); i++)
    { 
        summ = 0;
        ColumnNumber =ColumnNumber+1;
        for (int j = 0; j < inputArray.GetLength(0); j++)
        {
            summ += inputArray[j, i];
        }
        //Console.WriteLine(summ);
        //Console.WriteLine(inputArray.GetLength(0));
        SredneeArifmetStolbza = summ/inputArray.GetLength(0);
        Console.WriteLine($"В столбце №{ColumnNumber} среднее арифметическое элементов {SredneeArifmetStolbza}");
    }
    
}

int[,] generatedArray = generate2DArray(3,4,1,10);
print2DArray(generatedArray);

SredneeArifmetStolbzov(generatedArray);
