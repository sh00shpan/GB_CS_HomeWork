/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int Input3DigitNumber (int userNumber)
{
    Console.WriteLine("Введите трехзначное число");
    int number= Convert.ToInt32(Console.ReadLine());

        if (number > 999 || number < 100)
        {
            Console.WriteLine("Введено некорректное число");
            return 0;
        }
        else
        {
            Console.WriteLine($"Введено число {number}");
            return number;
        }
}
//Console.WriteLine(Input3DigitNumber(1));

void PrintSecondNumber (int i)
{
    if (i == 0)
    {
        Console.WriteLine("Введите трехзначное число");
    }
    else
    {
    while (i >= 100) 
    i /= 10;
    int SecondDigit = i % 10;
    Console.WriteLine($"Вторая цифра данного числа {SecondDigit}");
    }
}

int User3DigitNumber = Input3DigitNumber(0);
PrintSecondNumber(User3DigitNumber);


