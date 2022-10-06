/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели");
int user_number= Convert.ToInt32(Console.ReadLine());

    if (user_number > 0 && user_number < 6)
    {
        Console.WriteLine("Не выходной");
    }

    else if (user_number == 6 || user_number == 7)
    {
        Console.WriteLine("Выходной");
    }
    
    else 
    {
       Console.WriteLine("Введень некорректный день недели"); 
    }