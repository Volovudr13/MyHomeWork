/*


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Kvadrat(int Num)
{
    int count = 1;
    Console.Write(Num + " => ");
    while ( count < Num )
    {
        Console.Write(count * count + " ");
        count ++;
    }

}
Console.WriteLine("Please put in your number ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0 )
{
    Kvadrat(num);
}
else
{
    Console.WriteLine("Pleas! Put in positive nomber");    
}

*/



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Line (int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt((zB-zA) * (zB-zA) + (xB - xA) * (xB - xA) + (yB - yA) * (yB - yA)); 
}


Console.WriteLine("Put in point xa ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Put in point ya ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Put in point za ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Put in point xb ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Put in point yb ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Put in point zb ");
int zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The distance is  " + Line(xA,yA,zA,xB,yB,zB));




// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
void Palindrom (int num)
{
    
    
    int number = num;
    int a = 0;

    while (number > 0 )
    {
        a = a * 10 + (number%10);
        number = number /10; 
    }
    if (num == a)
    {
            Console.WriteLine(" It is palindrom");
    }
    else
    {
        Console.WriteLine("It is not palindrom");
    }
}

int YourNumber = new Random().Next(10000,99999); // Или: Console.WriteLine("Please in put your five-digital nomber!")
Console.WriteLine(YourNumber);                   //      int YourNumber = Convert.ToInt32(Console.ReadLine());
Palindrom(YourNumber);

*/