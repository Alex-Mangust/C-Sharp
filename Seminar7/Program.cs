/*  Задача 46. Задайте двумерный массив размером mxn, заполненный целыми числами.
    m = 3, n = 4
    1 4 8 19
    5 2 33 2
    77 3 8 1
*/

// System.Console.Write("Укажите первую размерность массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Укажите вторую размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] arrayOne = new int[m, n];
// void InputArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(10, 100);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if(j == 0) System.Console.Write("|");
//             System.Console.Write(array[i, j]);
//             if(j == array.GetLength(1) - 1) System.Console.Write("|");
//             else System.Console.Write("; ");
//         }
//         System.Console.WriteLine();
//     }
// }
// InputArray(arrayOne);
// PrintArray(arrayOne);

/*  Задача 48. Задайте двумерный массив размера m на n, каждый элемент в массиве
    находится по формуле: A[m, n] = m + n.
    Выведите полученный массив на экран.
    m = 3, n = 4;
    0 1 2 3
    1 2 3 4
    2 3 4 5
*/

// int m = 3, n = 4;
// int[,] arrayOne = new int[m, n];
// void InputArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = i + j;
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if(j == 0) System.Console.Write("|");
//             System.Console.Write(array[i, j]);
//             if(j == array.GetLength(1) - 1) System.Console.Write("|");
//             else System.Console.Write("; ");
//         }
//         System.Console.WriteLine();
//     }
// }
// InputArray(arrayOne);
// PrintArray(arrayOne);

/*  Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса
    чётные, и замените эти элементы на их квадраты.
    Например, изначально массив               Новый массив будет выглядеть
    выглядит так:                             вот так:
    1 4 7 2                                   1 4 7 2
    4 9 2 3                                   4 81 2 9
    8 4 2 4                                   8 4 2 4
*/

using System.Text.RegularExpressions;

System.Console.Write("Введите первую размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите вторую размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrayOne = new int[m, n];

void InputArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0) array[i, j] = (int)Math.Pow(array[i, j], 2);
        }
    }
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0) System.Console.Write("|");
            System.Console.Write(array[i, j]);
            if(j == array.GetLength(1) - 1) System.Console.Write("|");
            else System.Console.Write("; ");
        }
        System.Console.WriteLine();
    }
}
InputArray(arrayOne);
PrintArray(arrayOne);
System.Console.WriteLine();
PowArray(arrayOne);
PrintArray(arrayOne);