﻿// Задача 34:
    // Задайте массив заполненный случайными положительными трёхзначными числами.
    // Напишите программу, которая покажет количество чётных чисел в массиве.
    // [345, 897, 568, 234] -> 2

int[] num = new int[4];
for (int i = 0; i < num.Length; i++)
    num[i] = new Random().Next(100, 1000);
foreach (int n in num)
{
    Console.Write($"{n} ");
}
Console.WriteLine();
int count = 0;
for (int a = 0; a < num.Length; a++)
    if (num[a] % 2 == 0)
        count++;

Console.WriteLine(count);