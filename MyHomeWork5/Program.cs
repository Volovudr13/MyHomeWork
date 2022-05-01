
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


/*

Console.WriteLine("in put first number : ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("in put second number : ");
int secondNum = Convert.ToInt32(Console.ReadLine());
int count = 1;


for (int i = 0; i < secondNum; i ++)
{
   count = count * firstNum;
}
Console.Write(count);

*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
// Работает только с двухзначными числами ( 


Console.WriteLine("in put your number : ");
int firstNum = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int k = 0;
if (firstNum <= 0)
{
    Console.WriteLine("Pleas in put positiv number!");
}
else
    for (int i = 0; i < firstNum; i++)
    {
        sum = firstNum%10;
        k = firstNum/10;
    }
Console.WriteLine(k + " ");
Console.WriteLine(sum + " ");
Console.WriteLine ($"{k} + {sum} = " + ( k + sum));

*/ 

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*

void ShowmeArray (int [] array) 
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.WriteLine ($"{(i + 1)} element is  =>  {array[i]}");
    }
}

int [] MainArray (int size)
{
    int [] massiv = new int [size];
    for (int i = 0; i < massiv.Length; i ++)
        {
            massiv[i] = new Random().Next(0,25);
        }
    return massiv;    
}
int [] home = MainArray(8);
ShowmeArray (home);

*/
