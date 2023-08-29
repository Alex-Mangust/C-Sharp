/*
    Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
    двумерного массива.
 
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2
*/


// System.Console.Write("Введите первую размерность массива: ");
// int rows = Convert.ToInt32(System.Console.ReadLine());
// System.Console.Write("Введите первую размерность массива: ");
// int colums = Convert.ToInt32(System.Console.ReadLine());
// int[,] matrix = new int[rows, colums];
// void InputArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(10, 100);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if(j == 0)
//             {
//                 System.Console.Write("[");
//             }
//             System.Console.Write(array[i,j]);
//             if(j == array.GetLength(1) - 1)
//             {
//                 System.Console.Write("]");
//             }
//             else
//             {
//                 System.Console.Write("; ");
//             }
//         }
//         System.Console.WriteLine();
//     }
// }
// void OrderingArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if(array[i, k] < array[i, k+1])
//                 {
//                     int temp = 0;
//                     temp = array[i, k+1];
//                     array[i, k+1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// InputArray(matrix);
// PrintArray(matrix);
// System.Console.WriteLine();
// OrderingArray(matrix);
// PrintArray(matrix);



/*
    Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей
    суммой элементов.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


System.Console.Write("Введите первую размерность массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите первую размерность массива: ");
int colums = Convert.ToInt32(System.Console.ReadLine());
int[,] matrix = new int[rows, colums];
void InputArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0)
            {
                System.Console.Write("[");
            }
            System.Console.Write(array[i,j]);
            if(j == array.GetLength(1) - 1)
            {
                System.Console.Write("]");
            }
            else
            {
                System.Console.Write("; ");
            }
        }
        System.Console.WriteLine();
    }
}
void SumElementArray(int[,] array)
{
    int min = int.MaxValue;
    int minLine = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        System.Console.WriteLine($"Сумма элементов {i+1} строки равняется - {sum}.");
        if(sum < min)
        {
            min = sum;
            minLine = i+1;
        }
    }
    System.Console.WriteLine($"{minLine} строка имеет наименьшую сумму элементов.");
}
InputArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
SumElementArray(matrix);



/*  
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3

    Результирующая матрица будет:
    18 20
    15 18
*/

/*  
    Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет
    построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)
*/

/*  
    Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07
*/