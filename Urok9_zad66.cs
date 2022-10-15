/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

Console.WriteLine("Input start number M");
int UserNumberStart = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input end number N");
int UserNumberEnd = Convert.ToInt32(Console.ReadLine());

printRangeSum(UserNumberStart, UserNumberEnd, 0);

void printRangeSum (int Start, int End, int SumStart)
{
    if (Start == End)
    {
        SumStart=SumStart+End;
        Console.Write($"сумма {SumStart}");
        return;
    }
    SumStart=SumStart+End;
    printRangeSum(Start, End-1,SumStart);
    //Console.Write($"after rec {SumStart}, ");
}