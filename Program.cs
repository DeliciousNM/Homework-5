﻿// Задача 34:
    // Задайте массив заполненный случайными положительными трёхзначными числами.
    // Напишите программу, которая покажет количество чётных чисел в массиве.
    // [345, 897, 568, 234] -> 2

// int[] num = new int[4];
// for (int i = 0; i < num.Length; i++)
//     num[i] = new Random().Next(100, 1000);
// foreach (int n in num)
// {
//     Console.Write($"{n} ");
// }
// Console.WriteLine();
// int count = 0;
// for (int a = 0; a < num.Length; a++)
//     if (num[a] % 2 == 0)
//         count++;

// Console.WriteLine(count);

// Задача 36:
    // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
for (int i = 0; i < num.Length; i++)
    num[i] = new Random().Next(1, 11);
foreach (int n in num)
{
    Console.Write($"{n} ");
}
Console.WriteLine();
int sum = 0;

for (int a = 1; a < num.Length; a+=2)
    sum = sum + num[a];

    Console.WriteLine($"Сумма элементов нечётных позиций — {sum}");