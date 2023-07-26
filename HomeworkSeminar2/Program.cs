// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = new Random().Next(100, 1000);
//  Console.WriteLine($"Вторая цифра числа {number} -> {number = (number /10) % 10}");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// (диапазон от 10 до 40000)

// int number = new Random().Next(10, 40000);
// if(number > 99 && number < 1000)
// {
//     Console.WriteLine($"Третья цифра числа {number} -> {number = number%10}");
// }
// else if (number > 1000 && number < 10000) // 1234
// {
//      Console.WriteLine($"Третья цифра числа {number} -> {number = (number/10)%10}");
// }
// else if (number > 10000) // 12345
// {
//     Console.WriteLine($"Третья цифра числа {number} -> {number = (number/100)%10}");
// }
// else
// {
//     Console.WriteLine("Третьей цифры в числе " + number + " нет");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да
// 1 -> нет
// (диапазон от 0 до 10)

int day = new Random().Next(0, 10);
if(day > 0 && day < 5)
{
    Console.WriteLine("Day = " + day);
    Console.WriteLine("Это не выходной!");
}
else if (day > 5 && day < 8)
{
    Console.WriteLine("Day = " + day);
    Console.WriteLine("Это выходной!");
}
else
{
    Console.WriteLine("Day = " + day);
    Console.WriteLine("Такого дня недели нет!");
}