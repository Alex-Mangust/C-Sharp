//Домашняя работа №1

/*2. Напишите программу, которая на вход принимает два
числа и выдает, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2, b = 10 -> max = 10
a = -9, b = -3 -> max = -3*/

// Console.Write("Введите первое число: ");
// int numberFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberSecond = Convert.ToInt32(Console.ReadLine());
// if (numberFirst > numberSecond)
// {
//     Console.WriteLine(numberFirst + " больше " + numberSecond);
// }
// else
// {
//     Console.WriteLine(numberSecond + " больше " + numberFirst);
// }


/*4. Напишите программу, которая прпнимает на ввод
три числа и выдает максимальное из этих чисел.
2, 3, 7 -> 7
44, 5, 72 -> 78
22, 3, 9 -> 22*/

// Console.Write("Введите первое число: ");
// int OneNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int TwoNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int ThreeNumber = Convert.ToInt32(Console.ReadLine());
// if((OneNumber > TwoNumber) && (OneNumber > ThreeNumber))
// {
//     Console.WriteLine(OneNumber);
// }
// else if((TwoNumber > OneNumber) && (TwoNumber > ThreeNumber))
// {
//     Console.WriteLine(TwoNumber);
// }
// else
// {
//     Console.WriteLine(ThreeNumber);
// }


/*6. Напишите программу, которая на ввод принимает число и выдает, является ли число четным
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    Console.WriteLine("Число чётное.");
}
else
{
    Console.WriteLine("Число нечётное.");
}
/*8. Напишите программу, которая на ввод принимает число
(N), а на выводе показывает все чётные число от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/