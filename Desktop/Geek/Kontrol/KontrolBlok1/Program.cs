// Напишите программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше или равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 


 string[] arrayPoetry = {"Кар", "! ", "ворона ", "прилетела ", "на ", "дубовый ", "сук ",
  "Кар", "! ", "другая ", "рядом ", "села ", "в ", "бок ", "соседку ", "тюк "};
   string[] arrayWords = new string[arrayPoetry.Length];
  void Choice(string[] arrayPoetry, string[] arrayWords)
  {
      int count = 0;
      for (int i = 0; i < arrayPoetry.Length; i++)
      {
      if(arrayPoetry[i].Length <= 3)
          {
          arrayWords[count] = arrayPoetry[i];
          count++;
          }
      }
  }
  Choice(arrayPoetry, arrayWords);