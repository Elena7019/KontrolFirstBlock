// Напишите программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 

string[] arrayPoetry = {"Кар", "!", " ворона ","прилетела ", "на", " дубовый ", "сук",
 "\r\n", "Кар", "!", " другая ", "рядом ","села ", "в ", "бок", " соседку ", "тюк"};
Console.WriteLine("Введен массив: " );
for (int i = 0; i < arrayPoetry.Length; i++)
    {
         Console.Write("{1}", i, arrayPoetry[i]);
    }
Console.WriteLine();
Console.WriteLine("Преобразовываем в массив из строк, длина которых меньше или равна 3 символам:");
 
string[] arrayWords = new string[arrayPoetry.Length];
void Choice(string[] arrayPoetry, string[] arrayWords)
{
    int count = 0; int x =3;
    for (int i = 0; i < arrayPoetry.Length; i++)
    {
        if(arrayPoetry[i].Length <= x)
        {
            arrayWords[count] = arrayPoetry[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("{1}", i, arrayWords[i]);
    }
    Console.WriteLine();
  }
Choice(arrayPoetry, arrayWords);
PrintArray(arrayWords);