﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов
// массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int[12];
// int sumPosNum = 0;
// int sumNegNum = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     System.Console.Write(array[i] + " ");
//     if(array[i] > 0)
//     {
//         sumPosNum+=array[i];
//     }
//     else
//     {
//         sumNegNum+=array[i];
//     }
// }
// System.Console.WriteLine("");
// System.Console.WriteLine($"Сумма полож. = {sumPosNum}, отриц. = {sumNegNum}");



// Задача 32: Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// System.Console.Write("Введите количество элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// System.Console.WriteLine("");
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     System.Console.Write(array[i] + " ");
// }
// System.Console.WriteLine("");
// for(int j = 0; j < array.Length; j++)
// {
//     array[j] = array[j] * -1;
//     System.Console.Write(array[j] + " ");
// }

// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// System.Console.WriteLine("Введите число");;
// int num = Convert.ToInt32(Console.ReadLine());
// bool isFind = false;
// int[] array = new int[5];
// System.Console.WriteLine("");
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 5);
//     System.Console.WriteLine(array[i]);
//     if(array[i] == num)
//     {
//         isFind = true;
//     }
// }
// if (isFind)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество
// элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[123];
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 160);
    System.Console.Write(array[i] + " ");
    if(array[i] > 9 && array[i] < 100)
    {
        count++;
    }
}
System.Console.WriteLine();
System.Console.WriteLine(count++);