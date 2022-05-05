// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int [] BildNewArrayCreate (int size)   
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("In put " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int [] a = BildNewArrayCreate (5); 
ShowmeArray(a);
Console.WriteLine();
void PositiveNum (int [] array)
{
    
    int positive = 0;
    int q = array.Length;
    for (int i = 0; i < q; i++ )
    {
        if (array[i] > 0)
        {
            
            Console.Write(array[i]); // Вот тут мне так и не удалось выводить результат нe  в столбик, а в линию .Console.WriteLine лишь увеличивает промежутки между числами в столбике.
            positive = positive +1;
            Console.WriteLine();
        }
        
        
       
    }   
    Console.WriteLine("The sum of positive numbers is => " + positive );  
}
PositiveNum(a);


*/

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int  DoubleNum (int num) 
{
    int mas = 0;
    while (num > 0)
    {

        mas = num%2; 
        num = num /2;
        Console.Write(mas); 
       
        
    }
    return mas;
}

DoubleNum (4);
Console.WriteLine();
 
 // Все дальнейшие попытки перевернуть число терпели фиаско .... ( 
     // Вот некоторые примеры : 
    
int [] Revers (int  array)
{
    
    int [] Awe = new int [array];           
    for (int i = 0, j =  Awe.Length-1; i<Awe.Length; i++,j--)   
    {
        Awe[i]=Awe[j];
    }
    
    return Awe;    
    
}


//


int [] DoubleNum (int num) 
{
    
    int [] mas = new int [num];
    for (int i = 0; i < mas.Length; i ++)
    {
        mas[i] = num%2; 
        num = num /2;
        Console.WriteLine(mas); 
       
        
    }
    return mas;
}

Console.WriteLine();
ShowmeArray (DoubleNum(11));

int Revers (int  array)
{
    int m = 0;
    int [] Awe = new int [array];           
    for (int i = Awe.Length-1; i>=0; i--)   
    {
        m = Awe[i];
    }
    
    return m;    
}

// Было ещё нескольо не рабочих вариантов.
// Как я понял это задание... Нужно создать метод принимающий на вход число вводимое пользователем. Далее это число нужно было преобразовать из десятичного значения в двоичное.
// Потом я запутался с методами. Поместить двоичное значение в массив и развернуть мне неудалось. Записать его сразу задом на перёд - тоже. 
// 

