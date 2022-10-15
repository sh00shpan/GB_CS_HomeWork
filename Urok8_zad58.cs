/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

int[,] generate2DArray(int hightAndwidth, int randomStart, int randomEnd)
{
    int[,] twoDarray = new int[hightAndwidth,hightAndwidth];
    for (int i = 0; i < hightAndwidth; i++)
    {
        for (int j = 0; j < hightAndwidth; j++)
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

int[,] MatrixMuliply(int[,] incomingArray1,int[,] incomingArray2)
{
    int[,] MatrixMultiplyResult = new int [incomingArray1.GetLength(0), incomingArray2.GetLength(1)];

            for (int i = 0; i < incomingArray1.GetLength(0); i++)
            {
                for (int j = 0; j < incomingArray2.GetLength(1); j++)
                {
                    for (int k = 0; k < incomingArray2.GetLength(0); k++)
                    {
                        MatrixMultiplyResult[i,j] += incomingArray1[i,k] * incomingArray2[k,j];
                    }
                }
            }

    return MatrixMultiplyResult;
}


int[,] generateArray1 = generate2DArray(2,1,10);
int[,] generateArray2 = generate2DArray(2,1,10);

print2DArray(generateArray1);
print2DArray(generateArray2);

int [,] ResultArray = MatrixMuliply(generateArray1, generateArray2);
Console.WriteLine("Результат");
print2DArray(ResultArray);