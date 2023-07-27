// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координату x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if(x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("4");
// }
// else
// {
//     Console.WriteLine("Точка лежит на оси.");
// }

// Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num == 1)
{
    Console.WriteLine("X и Y больше 0");
}
else if (num == 2)
{
    Console.WriteLine("X меньше 0, а Y больше 0");
}
else if (num == 3)
{
    Console.WriteLine("X и Y меньше 0");
}
else if (num == 4)
{
    Console.WriteLine("X больше 0, а Y меньше 0");
}
else
{
    Console.WriteLine("Пожалуйста введите номер четверти от 1 до 4");
}