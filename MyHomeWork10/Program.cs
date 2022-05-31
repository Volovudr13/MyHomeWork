﻿/*

//   Задача 1

//Задайте массив строк. Напишите программу, которая считает кол-во слов в массиве, начинающихся на гласную букву.

int WordsCount(string[] array)
{
    int count = 0;
    string vowels = "aeiouy";

    for(int i = 0; i < array.Length; i++)
    {    
        for(int j = 0; j < vowels.Length; j++)
        {
             
            if(array[i].ToLower()[0] == vowels[j])
            {
    
                count++;
            }
        }
    }
    return count;
}

string[] MyArray = { "abc", "dif", "ghr", "xyz", "ops"};
Console.Write("Кол-во слов в массиве, начинающихся на гласную букву => ");
Console.WriteLine(WordsCount(MyArray));
Console.WriteLine();




//   Задача 2

//  Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.


 
string[] UnitedList(string[] array)
{
    int arLen = array.Length / 2 + array.Length % 2;
    string[] outArray = new string[arLen];
    for(int i = 0, j = 0; i < array.Length - 1; i += 2, j++)
    {
        outArray[j] = (array[i] + array[i + 1]);
        if(array.Length % 2 != 0 && j == arLen - 2)
        {
            outArray[arLen - 1] = array[array.Length-1];
            break;
        }
    }
    return outArray;
}

string[] familyArray = { "Vladi", "mir",
                       "An", "na",
                       "pa", "pa",
                       "ma", "ma"};

Console.WriteLine("{\"" + string.Join("\", \"", familyArray)+ "\"" + " => " + "\"" + string.Join("\", \"", UnitedList(familyArray)) + "\"}");

*/


