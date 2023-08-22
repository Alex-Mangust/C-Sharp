/*  Задача 42. Напишите программу, которая будет преобразовывать десятичное число
    в двоичное.
    45 -> 101101
    3  -> 11
    2  -> 10
*/


// // Мой вариант решения: 

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(System.Console.ReadLine());
// string numberTwo = "";
// while(number > 0)
// {
//     numberTwo = number%2 + numberTwo;
//     number = number/2;
// }
// if(number == 0)
// {
//     numberTwo = Convert.ToString(number);
// }
// else if (number < 0)
// {
//     System.Console.WriteLine("Вы ввели отрицательное число!");
// }
// System.Console.WriteLine(numberTwo);

// Мой вариант решения с помощью массива:

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numTwo = num;
int m = 0;
while(numTwo > 0)
{
    numTwo /= 2;
    m++;
}
int[] array = new int[m];
for(int i = 1; i <= m; i++)
{
    array[m - i] = num%2;
    num /= 2;
}
for(int j = 0; j < m; j++)
{
    System.Console.Write(array[j]);
}
