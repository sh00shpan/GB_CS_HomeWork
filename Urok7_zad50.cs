/*
Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
2 -> 7
9 -> 4

[0][1][2][3]
 1  4  7  2
[4][5][6][7]
 5  9  2  3
[8][9][10][11]
 8  4  2  4
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

void printArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        Console.Write($" индекс [{i}]");
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }

}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

int[] Transform2DArraytoLinearArray(int[,] incomingArray)
{
    int z = 0;
    int[] NewArray = new int[incomingArray.GetLength(0)*incomingArray.GetLength(1)];
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            NewArray[z++] = incomingArray[i, j];
        }
    }
    return NewArray;
}

void getUserIndexInArray(int[] array, int userIndex)
{
    int Result =0;
    if (userIndex > array.Length)
    {
        Console.WriteLine($"Число c индексом {userIndex} в массиве нет");
    }

    for (int i = 0; i < array.Length; i++)
    {
        if(i == userIndex)
        {
            Result = array[i];
            Console.WriteLine($"Число c индексом {userIndex} есть в массиве это - {array[userIndex]}");
        }
    }
}

int[,] generateArray = generate2DArray(4,4,1,10);
print2DArray(generateArray);
int[] TransformedArray = Transform2DArraytoLinearArray(generateArray);
//printArray(TransformedArray);

Console.WriteLine("Введите Индекс числа для поиска");
int UserIndexToSearch = Convert.ToInt32(Console.ReadLine());
getUserIndexInArray(TransformedArray, UserIndexToSearch);
