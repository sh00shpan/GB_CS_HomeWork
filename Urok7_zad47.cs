﻿/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double[,] generate2DArray(int hight, int width)
{
    double[,] twoDarray = new double[hight,width];
    Random randomNumber = new Random();
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDarray[i,j] = Math.Round((randomNumber.NextDouble()*10),1);
        }
        
    }
    return twoDarray;
}

void print2DArray(double[,] arrayToPrint)
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

double[,] generatedArray = generate2DArray(7,5);
print2DArray(generatedArray);

