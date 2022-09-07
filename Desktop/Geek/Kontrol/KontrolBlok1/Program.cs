// Напишите программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше или равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 

string[] arrayPoetry = {"Кар", "! ", "ворона ", "прилетела ", "на ", "дубовый ", "сук ",
"\r\n", "Кар", "! ", "другая ", "рядом ", "села ", "в ", "бок ", "соседку ", "тюк "};
for (int i = 0; i < arrayPoetry.Length; i++)
    {
        Console.Write("{1}", i, arrayPoetry[i]);
    }
Console.WriteLine();
string[] arrayWords = new string[arrayPoetry.Length];
void Choice(string[] arrayPoetry, string[] arrayWords)
{
    int count = 0;
    for (int i = 0; i < arrayPoetry.Length; i++)
    {
        if(arrayPoetry[i].Length <= 4)
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