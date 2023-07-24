// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if((num%7 == 0) && (num%23 == 0)) Console.WriteLine("Число кратное и 7, и 23");
else if ((num%7 == 0) && (num%23 != 0)) Console.WriteLine("Число кратное только 7");
else if ((num%7 != 0) && (num%23 == 0)) Console.WriteLine("Число кратное только 23");
else Console.WriteLine("Число не кратное ни 7, ни 23");