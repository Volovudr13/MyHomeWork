// Задача 1 : Найти большее и меньшее числа.
/*

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Max is " + num1);
    Console.WriteLine("Min is " + num2);
}
else
{
    Console.WriteLine("Max is " + num2);
    Console.WriteLine("Min is " + num1);
}

*/


// Задача 2: Найти максимально число.


/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1>max) max = num1;
if (num2>max) max = num2;
if (num3>max) max = num3;
Console.WriteLine("Max integer is " + max);
*/

// Задача 3 : Определить является ли вводное число чётным.
/*
Console.Write("Input first integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2 == 0)
{
    Console.Write("Число " +  num  );
    Console.Write(" делится на два без остатка");
}
else
{
    Console.Write("Число " + num  );
    Console.Write(" не делится на два без остатка");
}
*/

// Задача 4:

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int Rem;
int current;



if (num < 0)
{
    current = num;
    num = num * (-1);
}

else
{
    current = -1* num;
}

while (current <= num)
{
    Rem = current % 2;
    if (Rem == 0)

        Console.Write(current + " ");
    current++;
}


