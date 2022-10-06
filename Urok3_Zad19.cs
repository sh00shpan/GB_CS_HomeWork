/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

Решаю строкой, потому что как сделать в инт всю голову уже сломал. как решить warning CS8600 и 02 я не знаю.
программа работает.
*/

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;
bool check = true;

for (int i = 0; i < len/2; i++)
{
    if (len !=5)
    {
        Console.WriteLine("Вы ввели не пятизначное число");
        break;
    }
    
    else if (number[i] != number[len - (i + 1)])
    {
        check = false;
        break;
    }   
}
if (check)
{
    Console.WriteLine($"Число {number} палингдром");
}
else
{
    Console.WriteLine($"Число {number} не палиндром");
}



