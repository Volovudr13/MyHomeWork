// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.



int[,] CreateArray(int size1, int size2)
{
    int[,] Array = new int[size1, size2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 10);
            Console.Write(Array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return Array;
}



void PrintArray(int[,] MainArray)
{
    Console.WriteLine();
    for (int i = 0; i < MainArray.GetLength(0); i++)
    {
        for (int j = 0; j < MainArray.GetLength(1); j++)
        {
            Console.Write(MainArray[i, j] + " ");
        }
        Console.WriteLine();
    }


}


int[,] ServesArray(int[,] NewArray)
{
    int temp;
    for (int i = 0; i < NewArray.GetLength(0); i++)
    {
        for (int j = 0; j < NewArray.GetLength(1); j++)
        {
            int min = j;
            for (int a = j + 1; a < NewArray.GetLength(1); a++)
            {

                if (NewArray[i, a] < NewArray[i, min])
                {
                    min = a;
                }

            }

            temp = NewArray[i, min];
            NewArray[i, min] = NewArray[i, j];
            NewArray[i, j] = temp;

        }

    }
    return NewArray;
}



Console.WriteLine("Input higth of matrix: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input weith of matrix: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

PrintArray(ServesArray(CreateArray(num1, num2)));




//2

// Напишите программу которая будет находить строку с наименьшей суммой элементов в прямоугольном массиве.




int [,] CreateArray (int size1, int size2)
 {
     int [,] Array = new int [size1,size2];
     for (int i = 0; i< Array.GetLength(0); i ++)
     {
         for (int j =0; j < Array.GetLength(1); j ++)
         {
             Array[i,j] = new Random().Next(0,10);
             Console.Write(Array[i,j] +" ");
         }
        Console.WriteLine();
     }
     return Array;
 }


int LineSum (int [,] matrix)
{
    int StringSum = 0;
    int MinStringSum = 0;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            if (i ==0)
            {
                MinStringSum += matrix [i,j];
                StringSum += matrix [i,j];
            }
            else
                StringSum+=matrix [i,j];
        }
        if (MinStringSum > StringSum)
        {
            index = i+1;
            MinStringSum = StringSum;
        }
    }
    return index;
}


Console.WriteLine("Input higth of matrix: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input weith of matrix: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int NewLineSum = LineSum(CreateArray(num1,num2));
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой элементов => " + NewLineSum);
