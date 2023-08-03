// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
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

System.Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
System.Console.WriteLine("");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine("");
for(int j = 0; j < array.Length; j++)
{
    array[j] = array[j] * -1;
    System.Console.Write(array[j] + " ");
}



