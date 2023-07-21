
/* 1. Напишите программу, которая на вход принимает
    числа и проверяет, является ли первое число квадратом
    второго.
    a = 25, b = 5 -> да
    a = 2, b = 10 -> нет
    a = 9, b = -3 -> да
    a = -3, b = 9 -> нет*/
// Console.Write("Введите число: ");
// int numberFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberSecond = Convert.ToInt32(Console.ReadLine());
// int nad = 0;
// if (numberFirst == numberSecond * numberSecond)
// {
//     Console.WriteLine("Да, первое число является квадратом второго.");
// }
// else
// {
//     Console.WriteLine("Нет, первое число не является квадратом второго.");

// }

/*3. Напишите программу, которая будет выдавать название
дня недели по заданному номеру.*/
// bool exit = false;
// while(!exit)
// {
//     exit = true;
//     Console.WriteLine("Какой день недели выберите: ");
//     Console.WriteLine("1. Понедельник");
//     Console.WriteLine("2. Вторник");
//     Console.WriteLine("3. Среда");
//     Console.WriteLine("4. Четверг");
//     Console.WriteLine("5. Пятница");
//     Console.WriteLine("6. Суббота");
//     Console.WriteLine("7. Воскресенье");
//     int day = Convert.ToInt32(Console.ReadLine());
//     if(day == 1)
//     {
//         Console.WriteLine("1. Понедельник");
//     }
//     else if (day == 2)
//     {
//         Console.WriteLine("2. Вторник");
//     }
//     else if (day == 3)
//     {
//         Console.WriteLine("3. Среда");
//     }
//     else if (day == 4)
//     {
//         Console.WriteLine("4. Четверг");
//     }
//     else if (day == 5)
//     {
//         Console.WriteLine("5. Пятница");
//     }
//     else if (day == 6)
//     {
//         Console.WriteLine("6. Суббота");
//     }
//     else if (day == 7)
//     {
//         Console.WriteLine("7. Воскресенье");
//     }
//     else
//     {
//         Console.WriteLine("Пожалуйста, выберите из предложенных вариантов.");
//         exit = false;
//     }
// }
/*5. Напишите программу, которая на вход принимает одно
число (N), а на выходе показывает все целые числа в
промежутке от -N до N*/

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine()), reN = N * -1;
// bool noNumber = true;
// if (N > 0)
// {
//     while(reN <= N)
//     {
//         if((reN % 2 == 0) && (reN != 0))
//         {
//             Console.Write(reN + " ");
//             noNumber = false;
//         }
//         reN++;
//     }
// }
// else if (N < 0)
// {
//       while(reN >= N)
//     {
//         if((reN % 2 == 0) && (reN != 0))
//         {
//             Console.Write(reN + " ");
//             noNumber = false;
//         }
//         reN--;
//     }
// }
// else
// {
//     Console.WriteLine("Вы ввели 0");
//     noNumber = false;
// }
// if (noNumber)
// {
//     Console.WriteLine("Четных чисел нет.");
// }
/*7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю
цифру этого числа
456 -> 6
782 -> 2
918 -> 8*/
// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(((number > 99) && (number < 1000)) || ((number < -99) && (number > -1000)))
// {
//     number = number%10;
//     Console.WriteLine(number);
// }
// else
// {
//     Console.WriteLine("Вы ввели не трехзначное число.");
// }