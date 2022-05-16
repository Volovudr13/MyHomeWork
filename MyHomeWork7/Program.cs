
//1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


/*

double [,] Massiv = new double[3,3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Massiv[i,j]= Math.Round( -10 + (11-(-10)) * new Random().NextDouble(),2);
        Console.Write (Massiv[i,j]  + " ");
    }
    Console.WriteLine();
}

*/






//2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

int [,] Array = new int [3,3];


for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Array[i,j] = new Random().Next(0,10);
        Console.Write(Array[i,j]);
        
        
    }
    Console.WriteLine();
}


 int Rep (int [,] mass, int Iposition, int Jposition)
 {
     for (int i =0; i < mass.GetLength(0); i++)
     {
        for (int j = 0; j< mass.GetLength(1); j++)
        {
            if (Iposition == i && Jposition == j )
            {
                return mass[i,j];
            }
        }
     }
    return-1;
}

Console.WriteLine("Input i positoin : ");
int Iposition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input j positoin : ");
int Jposition = Convert.ToInt32(Console.ReadLine());

int Veb = Rep (Array,Iposition,Jposition);
Console.WriteLine(Veb);

*/



//3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*

double [,] MyArray = new double [,]
{
    {0,1,2},
    {3,4,5},
    {6,7,8}
};

for (int i = 0; i < MyArray.GetLength(0); i++)
{
    for (int j =0; j < MyArray.GetLength(1); j++)
    {
        Console.Write(MyArray[i,j] + " ");
    }
    Console.WriteLine();
}


double a = MyArray[0,0] + MyArray[1,0] + MyArray[2,0];
double b =  MyArray[0,1] + MyArray[1,1] + MyArray[2,1];
double c = MyArray[0,2] + MyArray[1,2] + MyArray[2,2];
Console.Write(a/3 + " ");
Console.Write(b/3 + " ");
Console.Write(c/3);

*/