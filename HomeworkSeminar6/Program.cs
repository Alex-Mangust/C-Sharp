// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// 1 вариант решения.

// System.Console.Write("Введите колличество рассматриваемых чисел: ");
// int numberCount = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[numberCount];
// for(int i = 0; i < array.Length; i++)
// {
//     System.Console.Write($"Введите {i+1} число: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("");
// }
// int count = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine("Вы ввели " + count + " чисел, которые больше нуля.");


// 2 вариант решения.

bool close = false;
int i = 0, count = 0;
while(!close)
{
    System.Console.WriteLine($"Введите {i+1} число. (Чтобы закончить ввод чисел, введите 'end')");
    string input = Console.ReadLine();
    i++;
    if(int.TryParse(input, out int number) && number > 0)
    {
        count++;
    }
    else if(input == "end")
    {
        close = true;
        i--;
    }
    else if(!int.TryParse(input, out int result))
    {
        System.Console.WriteLine("Ошибка! Пожалуйста введите число!");
        i--;
    }
}
System.Console.Write($"Вы ввели {i} чисел.");
if(i > 0)
{
    System.Console.Write($" Из них {count} больше нуля.");
}



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// System.Console.Write("Введите значение b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите значение k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите значение b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите значение k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// //k1 * x + b1 = k2 * x + b2

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;
// System.Console.WriteLine(x + ";" + y);