

// 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.



/*
int [] BildNewArrayRandome (int size, int min, int max)  
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max +1); 
    return array;
}   

void ShowmeArray (int [] array) 
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
}

int [] ror = BildNewArrayRandome (10,100,999);
ShowmeArray( ror);
Console.WriteLine();
for (int i = 0; i<ror.Length; i ++)
{
    if (ror[i]%2==0 )
    Console.Write(ror[i] + " ");
}

*/


//2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*

int [] BildNewArrayRandome (int size)  
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next( 0,100); 
    }
    return array;
}   

void ShowmeArray (int [] array) 
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
}

int [] ror = BildNewArrayRandome (10);
ShowmeArray( ror);

Console.WriteLine();
int sum = 0;
for (int i = 0; i<ror.Length; i ++)
{
    if (ror[i]%2==1 )
    
    
    Console.Write(ror[i] + " "); 
    sum += ror[i];
}
Console.WriteLine();
Console.Write(sum);
*/


int [] BildNewArrayRandome (int size)  
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next( 0,100); 
    }
    return array;
}   

void ShowmeArray (int [] array) 
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
}

int [] ror = BildNewArrayRandome (10);
ShowmeArray( ror);
Console.WriteLine();
int max = 0;
int min = 0;
for (int i = 0; i < ror.Length; i ++)
{
    if (ror[i]>max)
    {
        max=ror[i];
        Console.WriteLine(max);
    }
    
    else
    {
        min = ror[i];

        if (ror[i]>min)
        {
            min =ror[i];
            Console.WriteLine(min);
        }
    }
}
int Web = max - min;
Console.WriteLine();
Console.WriteLine("Разница между максимальныи и минимальным эллементом = > " + Web);
