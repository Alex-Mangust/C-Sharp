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
// Console.Write("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());
// switch(num)
// {
//     case 1:
//     {
//         Console.WriteLine("X > 0 Y > 0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("X < 0 Y > 0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("X < 0 Y < 0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("X > 0 Y < 0");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Пожалуйста введите номер четверти от 1 до 4");
//         break;
//     }
// }


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// корень из((x2 - x1)^2 + (y2 -y1)^2))

// double num1 = Math.Pow(5, 3); // Возведение в степень. Работает с типом double
// Console.WriteLine(num1);
// double num2 = Math.Sqrt(25); // Корень
// Console.WriteLine(num2);

// Console.WriteLine("Введите координаты первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// double s = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
// Console.WriteLine(s);


// Задача 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i <= n; i++)
{
    // double y = Math.Pow(i, 2);
    Console.WriteLine(Math.Pow(i, 2)); 
}
