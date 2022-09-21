/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("ВВедите значени числа А");
int user_number_a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите значени числа В");
int user_number_b = Convert.ToInt32(Console.ReadLine());

 {
    if (user_number_a == user_number_b)
   
        Console.WriteLine("Числа равны");
    
    else if (user_number_a > user_number_b)
    
        Console.WriteLine($"Число А {user_number_a} Больше числа В {user_number_b}");
   
    else if (user_number_a < user_number_b)
        
        Console.WriteLine($"Число B {user_number_b} Больше числа A {user_number_a}");

    else 

        Console.WriteLine("Ошибка ввода чисел");

}