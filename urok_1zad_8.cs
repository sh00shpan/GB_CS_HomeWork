/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
 а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
int user_number = Convert.ToInt32(Console.ReadLine());
int start_number = 1;
int count_number = start_number;

while (count_number <= user_number)
{
    if (count_number % 2 == 0)

    //Console.WriteLine("число четное");
	//Console.WriteLine(user_number);
    Console.WriteLine($"Четные числа следющие{count_number}");

    count_number += 1;

}

