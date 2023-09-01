/*
    Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные
    числа в промежутке от 1 до N.
*/

// Мое решение:

// int Recurcia(int N, int Min)
// {
//     if(N > Min)
//     {
//         System.Console.Write(Min);
//         if(N > Min)
//         {
//             System.Console.Write("; ");
//         }
//         Min++;
//         return Recurcia(N, Min);
//     }
//     else if(N < Min)
//     {
//         System.Console.Write(Min);
//         if(N < Min)
//         {
//             System.Console.Write("; ");
//         }
//         Min--;
//         return Recurcia(N, Min);
//     }
//     else
//     {
//         System.Console.WriteLine(N);
//         return 0;
//     }
// }
// System.Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(System.Console.ReadLine());
// int min = 1;
// Recurcia(n, min);


// Решение преподователя:

// System.Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// string PrintNumbers(int start, int end)
// {
//     if(start == end)
//     {
//         return start.ToString();
//     }
//     if(end > start)
//     {
//         return (start + " " + PrintNumbers(start+1, end));
//     }
//     else
//     {
//         return (start + " " + PrintNumbers(start-1, end));
//     }
// }
// Console.WriteLine(PrintNumbers(1, num));


/*
    Задача 65. Задайте значения M и N. Напишите программу, которая выведет все
    натуральные числа в промежутке от M до N;
*/

// System.Console.Write("Введите значение M: ");
// int m = int.Parse(Console.ReadLine());
// System.Console.Write("Введите значение N: ");
// int n = int.Parse(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if(start == end)
//     {
//         return start.ToString();
//     }
//     if(end > start)
//     {
//         return start + " " + PrintNumbers(start+1, end);
//     }
//     else
//     {
//         return start + " " + PrintNumbers(start-1, end);
//     }
// }
// System.Console.Write("Числа в промежутке от M до N -> " + PrintNumbers(m, n));


/*
    Задача 67. Напишите программу, которая будет принимать на вход число и возвращать
    сумму его цифр.
    453 -> 12    
    45 -> 9
*/


// Мое решение

// int Sum(string numbers, int sumNumbers, int count)
// {
//     if(count < numbers.Length)
//     {
//         sumNumbers += int.Parse(numbers[count].ToString());
//         count++;
//         return Sum(numbers, sumNumbers, count);
//     }
//     return sumNumbers;
// }
// System.Console.Write("Введите число: ");
// string num = Console.ReadLine();
// int sum = 0, count = 0;
// System.Console.Write("Сумма чисел, введенного вами числа, равняется -> " + Sum(num, sum, count));


// Решение преподователя

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());


// Console.WriteLine(PrintNumbers(num));

// int PrintNumbers(int num)
// {
// if(num<=0)
// {
// return 0;
// }
// return (num%10+PrintNumbers(num/10));
// }


/*
    Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит
    число А в целую степень B с помощью рекурсии.
    A = 3; B = 5 -> 243 (3⁵)
    A = 2; B = 3 -> 8
*/

double Power(int numbers, int powerNumbers, int result)
{
    if(powerNumbers == 0)
    {
        return result;
    }
    if(powerNumbers < 0)
    {
        return (1/Math.Pow(numbers, powerNumbers));
    }
    result = result * numbers;
    return Power(numbers, powerNumbers - 1, result);
}

System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
System.Console.Write("Введите степень, в которую нужно возвести число: ");
int power = int.Parse(Console.ReadLine());
int res = 1;
System.Console.WriteLine(Power(num, power, res));