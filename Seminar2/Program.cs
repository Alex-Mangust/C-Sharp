// Написать программу, которая будет принимать на вход два числа и выводить, является ли
// второе число кратным первому. Если число 2 не кратно 1, про программа выводит остаток
// от деления.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num%num1 == 0) Console.WriteLine("Числа кратные");
else Console.WriteLine("Остаток равен " + num%num1);