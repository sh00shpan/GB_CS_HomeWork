/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

*/

Console.WriteLine("Input number N");
int UserNumber = Convert.ToInt32(Console.ReadLine());
printRange(UserNumber);

void printRange (int N)
{
    if (N == 0)
    {
        return;
    }
    printRange(N-1);
    Console.Write($"{N}, ");   
}