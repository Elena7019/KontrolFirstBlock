// Напишите программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше или равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 


void Choice(string[] args)
{
  string[] Crow = {"Кар", "! ", "ворона ", "прилетела ", "на ", "дубовый ", "сук ",
  "Кар", "! ", "другая ", "рядом ", "села ", "в ", "бок ", "соседку ", "тюк "};
   string[] array2 = new string[Crow.Length];
   for (int i = 0; i < Crow.Length; i++)
      Console.Write("{1}", i, Crow[i]);
}
Choice(args);
/*string[] array1 = {"Кар", "!", "ворона", "прилетела", "на", "дубовый", "сук", "Кар", "!", "другая", "рядом", "села", "в", "бок", "соседку", "тюк"};
 
  void Choice(string[] array1, string[] array2)
  {
      int count = 0;
      for (int i = 0; i < array1.Length; i++)
      {
      if(array1[i].Length <= 3)
          {
          array2[count] = array1[i];
          count++;
          }
      }
  }
  void PrintArray(string[] array)
  {
      for (int i = 0; i < array.Length; i++)
      {
          Console.Write($"{array[i]} ");
      }
      Console.WriteLine();
  }
  Choice(array1, array2);
PrintArray(array1);
// PrintArray(array2);*/
