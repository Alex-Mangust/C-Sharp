/*  Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами
    первую и последнюю строку массива.
*/

// System.Console.Write("Введите первую размерность массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите вторую размерность массива: ");
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
//             if(j == 0) System.Console.Write("[");
//             System.Console.Write(array[i, j]);
//             if(j == array.GetLength(1) - 1) System.Console.Write("]");
//             else System.Console.Write("; ");
//         }
//         System.Console.WriteLine();
//     }
// }
// void InvertArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(1); i++)
//     {
//         int temp = 0;
//         temp = array[0, i];
//         array[0,i] = array[array.GetLength(1) - 1, i];
//         array[array.GetLength(0) - 1, i] = temp;
//     }
// }
// InputArray(arrayOne);
// PrintArray(arrayOne);
// System.Console.WriteLine();
// InvertArray(arrayOne);
// PrintArray(arrayOne);



/*  Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет
    строки на столбцы. В случае, если это невозможно, программа должна вывести
    сообщение для пользователя.
*/

// System.Console.Write("Введите первую размерность массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите вторую размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];
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
//             if(j == 0) System.Console.Write("[");
//             System.Console.Write(array[i, j]);
//             if(j == array.GetLength(1) - 1) System.Console.Write("]");
//             else System.Console.Write("; ");
//         }
//         System.Console.WriteLine();
//     }
// }
// void InvertColomsArray(int[,] array)
// {
//     int[,] matrixTemp = new int[array.GetLength(0), array.GetLength(1)];
//     if(array.GetLength(0) == array.GetLength(1))
//     {
//         for(int i = 0; i < array.GetLength(0); i++)
//         {
//             for(int j = 0; j < array.GetLength(1); j++)
//             {
//                 matrixTemp[j, i] = matrix[i, j];
//             }
//         }
//         matrix = matrixTemp;
//     }
//     else System.Console.WriteLine("Поменять строки и столбцы невозможно!");
// }
// InputArray(matrix);
// PrintArray(matrix);
// System.Console.WriteLine("Если хотите поменять строки и столбцы местами, введите 1.");
// int invert = Convert.ToInt32(Console.ReadLine());
// if(invert == 1)
// {
//     InvertColomsArray(matrix);
//     PrintArray(matrix);
// }


/*  Задача 59. Задайте массив из целых чисел. Напишите программу, которая удалит
    строку и столбец, на пересеченни которых расположен наиментьший элемент массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

    Наименьший элемент - 1. На выходе получим слудующий массив:
    9 2 3
    4 2 4
    2 6 7
*/

System.Console.Write("Введите первую размерность массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите вторую размерность массива: ");
int coloms = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, coloms];
int minElement = int.MaxValue;
int rowsMinElement = 0;
int colomsMinElement = 0;
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
            if(j == 0) System.Console.Write("[");
            System.Console.Write(array[i, j]);
            if(j == array.GetLength(1) - 1) System.Console.Write("]");
            else System.Console.Write("; ");
        }
        System.Console.WriteLine();
    }
}
void DeleteCrossArray(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(i != rowsMinElement)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(j != colomsMinElement)
                {
                    if(j == 0) System.Console.Write("[");
                    System.Console.Write(array[i, j]);
                    if(j == array.GetLength(1) - 1) System.Console.Write("]");
                    else System.Console.Write("; ");
                }
            }
            System.Console.WriteLine();
        }
    }
}
void FoundMinElementArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minElement)
            {
                minElement = array[i,j];
                rowsMinElement = i;
                colomsMinElement = j;
            }
        }
    }
    System.Console.WriteLine($"Минимальный элемент массива - {matrix[rowsMinElement, colomsMinElement]}");
}
InputArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
FoundMinElementArray(matrix);
DeleteCrossArray(matrix);