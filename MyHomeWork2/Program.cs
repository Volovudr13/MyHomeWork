// Задача 1.  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
void SecondNum()
{
    int num = new Random().Next(100,999);
    Console.WriteLine(num);
    int num1 = num %100;
    int num2 = num1 / 10;
    Console.WriteLine(num1);
    Console.WriteLine(num2);

}

SecondNum();
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
void ThirdNumber()

{   
    int q = new Random().Next(0,999);
    Console.WriteLine(q);

    if (q >= 100)
    {
        q = (q % 100) % 10;
        Console.WriteLine(q);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет!");

    }
}

ThirdNumber();
*/


// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
void Week()
{
    int q = new Random().Next(0,8);
    if (q > 5 && q < 8)
    {
        Console.WriteLine(q + " It is Off day");
    }
    else
    {
        Console.WriteLine(q + " This day is not off day");
    }
}
Week();

*/

