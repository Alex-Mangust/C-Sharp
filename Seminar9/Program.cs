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

System.Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if(start == end)
    {
        return start.ToString();
    }
    if(end > start)
    {
        return start + " " + PrintNumbers(start+1, end);
    }
    else
    {
        return start + " " + PrintNumbers(start-1, end);
    }
}
System.Console.Write("Числа в промежутке от M до N -> " + PrintNumbers(m, n));