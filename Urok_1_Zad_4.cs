/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int input3DigitNumber(int number)

 {

    Console.WriteLine("ВВедите трехзначное число");
    int user_number_a= Convert.ToInt32(Console.ReadLine());

    if (user_number_a > 999 || user_number_a < 100)
   
        Console.WriteLine("Число некорректное");
    
    else 

        Console.WriteLine("число корректное");
        return user_number_a;
}

int getMaxDigitFromNumber(int number)

{
    int maxNumber = 0;
    while (number > 0)
    {
        int maxDigit = number % 10;
        if (maxNumber < maxDigit)
        {
            maxNumber = maxDigit;
        }
        number = number / 10;
    }
    return maxNumber;
}


int inputNumber = input3DigitNumber(0);
int maxDigit = getMaxDigitFromNumber(inputNumber);
Console.WriteLine($"Для числа {inputNumber}, макс число {maxDigit}");

/*
Комментарий - не знаю как остановить программу если число некорректное. break не получается использовать
*/