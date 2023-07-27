// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num > 9999 && num < 100000)
// {
//     string numStr = num + string.Empty;
//     if(numStr[0] == numStr[4] && numStr[1] == numStr[3]) Console.WriteLine($"Да, число {num} является палиндромом.");
//     else Console.WriteLine($"Нет, число {num} не является палиндромом.");
// }
// else Console.WriteLine("Вы ввели не пятизначное число");



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Введите координаты первой точки");
// Console.Write("x = ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y = ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z = ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки");
// Console.Write("x = ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y = ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z = ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// Console.Write($"Расстояние между точкой A({x1},{y1},{z1}) и точкой B({x2},{y2},{z2}) -> " + Math.Round(result, 2));



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
} 