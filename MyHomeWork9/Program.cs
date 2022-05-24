// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumNums (int m, int n)
{
    if (m<= n)
    {
       return m + SumNums(m+1,n); 
    }
    else
        return 0;
}
Console.Write(SumNums(1,15));
*/



// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*
int SumNums (int m)
{
    if (m < 10)
       return m; 

    return m%10  + SumNums(m/10); 
    
}

Console.Write(SumNums(777));
*/