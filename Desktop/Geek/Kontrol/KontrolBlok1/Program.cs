﻿// Напишите программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше или равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
void Crow(string[] args)
{
  string[] Crow = {"Кар", "! ", "ворона ", "прилетела ", "на ", "дубовый ", "сук ",
  "Кар", "! ", "другая ", "рядом ", "села ", "в ", "бок ", "соседку ", "тюк "};
    for (int i = 0; i < Crow.Length; i++)
      Console.Write("{1}", i, Crow[i]);
}
Crow(args);