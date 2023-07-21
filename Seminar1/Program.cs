
/* 1. Напишите программу, которая на вход принимает
    числа и проверяет, является ли первое число квадратом
    второго.
    a = 25, b = 5 -> да
    a = 2, b = 10 -> нет
    a = 9, b = -3 -> да
    a = -3, b = 9 -> нет*/
Console.Write("Введите число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
int nad = 0;
if (numberFirst == numberSecond * numberSecond)
{
    Console.WriteLine("Да, первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Нет, первое число не является квадратом второго.");

}