/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double formula3Dkoordinat()

{
    Console.WriteLine("Точка 1 координаты Х");
    int tochka_1_X= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 1 координаты У");
    int tochka_1_Y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 1 координаты Z");
    int tochka_1_Z = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Точка 2 координаты Х");
    int tochka_2_X= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 2 координаты У");
    int tochka_2_Y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка 2 координаты Z");
    int tochka_2_Z = Convert.ToInt32(Console.ReadLine());
    

    double result = Math.Sqrt(
        Math.Pow(tochka_1_X - tochka_2_X, 2) 
        + Math.Pow(tochka_1_Y - tochka_2_Y, 2) 
        + Math.Pow(tochka_1_Z - tochka_2_Z, 2) 
        );
    return result;

    
}

double result = formula3Dkoordinat();
Console.WriteLine(result);

