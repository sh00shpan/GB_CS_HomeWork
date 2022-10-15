/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[,,] generate3DArray(int HightWidthDepth, int randomStart, int randomEnd)
{
    int[,,] ThreeDArray = new int[HightWidthDepth,HightWidthDepth,HightWidthDepth];
    List<int> ListWithUsedNumbers = new List<int>();

    for (int i = 0; i < HightWidthDepth; i++)
    {
        for (int j = 0; j < HightWidthDepth; j++)
        {
            for (int k = 0; k < HightWidthDepth; k++)
            {
                while(ThreeDArray[i,j,k]==0)
                {
                    int RandomNumber = new Random().Next(randomStart, randomEnd);
                    if(!ListWithUsedNumbers.Contains(RandomNumber)) 
                    {
                        ListWithUsedNumbers.Add(RandomNumber);
                        //Console.WriteLine($"{RandomNumber} число свободно");
                        ThreeDArray[i,j,k] = RandomNumber;
                    }
                    else
                    {
                        //Console.WriteLine($"{RandomNumber} число занято. пропуск");
                    }
                }
                Console.WriteLine($"{ThreeDArray[i,j,k]} ({i},{j},{k})");
            } 
            
        }
        
    }
    return ThreeDArray;
}

int[,,] generatedArray = generate3DArray(2,10,99);

