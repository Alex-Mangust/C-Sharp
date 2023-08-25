/*
    Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/


System.Console.Write("Введите первую размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите вторую размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arrayOne = new double[m, n];
int count = 0;
void InputArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int num = new Random().Next(-100, 100);
            array[i, j] = new Random().NextDouble() * num;
            if(array[i, j] > -10 && array[i, j] < 3) count++;
        }
    }
}
void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0) System.Console.Write("[");
            System.Console.Write(Math.Round(array[i, j], 2));
            if(j == array.GetLength(1) -1) System.Console.Write("]");
            else System.Console.Write("; ");   
        }
        System.Console.WriteLine();
    }
}
InputArray(arrayOne);
PrintArray(arrayOne);
System.Console.WriteLine($"В массиве {count} элементов находятся в диопазоне от -10 до 3.");


/*  
    Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    17 -> такого числа в массиве нет
*/

/*  
    Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/