// Напишите программу, которая выводит случайное трехзначное число и
//  удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
int num1 = num/100, num2 = num%10;
Console.WriteLine(num);
int result = num1 * 10 + num2;
Console.WriteLine(result);