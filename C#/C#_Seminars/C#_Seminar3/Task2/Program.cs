﻿/*
Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]

*/

int[] array = new int[10] { 1, -5, 6, 8, 2, -7, -2, 9, -5, 9 };

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}