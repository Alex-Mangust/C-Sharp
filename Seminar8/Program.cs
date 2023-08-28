/*  Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами
    первую и последнюю строку массива.
*/

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
            array[i,j] = new Random().Next(10, 100);
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
void InvertArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        temp = array[0, i];
        array[0,i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
}
InputArray(arrayOne);
PrintArray(arrayOne);
System.Console.WriteLine();
InvertArray(arrayOne);
PrintArray(arrayOne);