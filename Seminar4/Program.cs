// Задача 24.  Задача 24: Напишите программу, которая принимает на вход число 
//(А) и выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

// int GetSumNum(int a)
// {
//     int sum = 0;
//     for(int i = 0; i <= a; i++)
//     {
//         sum += i;
//     }

//     return sum;
// }

// Console.Write("Введите число: ");
// int sum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetSumNum(sum));

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// 1 способ:

// int GetNum(int num)
// {
//     int count;
//     if(num > 0 && num < 10)
//     {
//         count = 1;
//     }
//     else if(num >= 10 && num < 100)
//     {
//         count = 2;
//     }
//     else if(num >= 100 && num < 1000)
//     {
//         count = 3;
//     }
//     else if(num >= 1000 && num < 10000)
//     {
//         count = 4;
//     }
//     else
//     {
//         count = 5;
//     }

//     return count;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetNum(num));

// 2 способ:

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int GetCountNum()
{
    int count = 0;
    while(num > 0)
    {
        num = num/10;
        count++;
    }
    return count;
}
Console.WriteLine(GetCountNum());