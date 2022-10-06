/*
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом 
второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
5 -> Пятница
*/

Console.WriteLine("ВВедите значени числа А");
int user_number_a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите значени числа В");
int user_number_b = Convert.ToInt32(Console.ReadLine());


int result = user_number_b * user_number_b;

    if (user_number_a == result)
    {
        Console.WriteLine("DA");
    }
    else
    {
        Console.WriteLine("NET");
    }

