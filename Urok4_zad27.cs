/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int InputUserNumber (int userNumber)
{
    Console.WriteLine("Введите число");
    int number= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Вы ввели число {number}");
    return number;
}

void SumOfDigits (int numberToSum)
{
    int result = 0;
    for (int n = numberToSum; n > 0; result += n % 10, n /= 10);
    Console.WriteLine($"Сумма цифр данного числа {result}");
}

int Number = InputUserNumber(0);
SumOfDigits(Number);

