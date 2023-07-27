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
switch(num)
{
    case 1:
    {
        Console.WriteLine("X > 0 Y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine("X < 0 Y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine("X < 0 Y < 0");
        break;
    }
    case 4:
    {
        Console.WriteLine("X > 0 Y < 0");
        break;
    }
    default:
    {
        Console.WriteLine("Пожалуйста введите номер четверти от 1 до 4");
        break;
    }
}