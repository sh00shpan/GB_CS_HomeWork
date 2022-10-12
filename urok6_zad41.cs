

int[] inputArrayWithNnumbers (int arraySize)
{
    Console.WriteLine("Укажите кличество числе в массиве");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] userArray = new int [n];
    
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите число № {i+1}");
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return userArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("Ваш введенный массив:");
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
void checkArrayforNumber (int[] ArrayToCheck, int NumberToCheckinArray)
{
    int counter = 0;
    for (int i = 0; i < ArrayToCheck.Length; i++)
    {
        if(ArrayToCheck[i] > NumberToCheckinArray)
        {
            counter +=1;
            Console.WriteLine(counter);
        }

    }
    Console.WriteLine($"Количество чисел которые больше {NumberToCheckinArray} составляет {counter}");
}
   
int[] inputedArray = inputArrayWithNnumbers(0);
printArray(inputedArray);
checkArrayforNumber(inputedArray,0);

