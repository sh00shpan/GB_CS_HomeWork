/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int InputUserNumber (int userNumber)
{
    Console.WriteLine("Введите число");
    int number= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Вы ввели число {number}");
    return number;

}
void PrintThirdDigit (int i)
{
    if (i < 99)
    {
        Console.WriteLine("Третьей цифры нет");
    }

    else
    {
        while (i >= 1000) 
        i /= 10;
        int SecondDigit = i % 10;
        Console.WriteLine($"Третья цифра данного числа {SecondDigit}");
    }
}

int User3DigitNumber = InputUserNumber(0);
PrintThirdDigit(User3DigitNumber);


