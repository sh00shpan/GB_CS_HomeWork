/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("ВВедите число A");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число B");
int userStepen = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 0; i < userStepen; i++)
{
    result *= userNumber;
}

Console.WriteLine(result);