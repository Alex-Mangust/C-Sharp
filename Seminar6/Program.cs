/*  Задача 42. Напишите программу, которая будет преобразовывать десятичное число
    в двоичное.
    45 -> 101101
    3  -> 11
    2  -> 10
*/


// // Мой вариант решения: 

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(System.Console.ReadLine());
// string numberTwo = "";
// while(number > 0)
// {
//     numberTwo = number%2 + numberTwo;
//     number = number/2;
// }
// if(number == 0)
// {
//     numberTwo = Convert.ToString(number);
// }
// else if (number < 0)
// {
//     System.Console.WriteLine("Вы ввели отрицательное число!");
// }
// System.Console.WriteLine(numberTwo);

// // Мой вариант решения с помощью массива:

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int numTwo = num;
// int m = 0;
// while(numTwo > 0)
// {
//     numTwo /= 2;
//     m++;
// }
// int[] array = new int[m];
// for(int i = 1; i <= m; i++)
// {
//     array[m - i] = num%2;
//     num /= 2;
// }
// for(int j = 0; j < m; j++)
// {
//     System.Console.Write(array[j]);
// }



/*  Задача 40. Напишите программу, которая принимает на вход три числа и проверяет,
    может ли существовать треугольник со сторонами такой длины.
    Теорема о неравенстве треугольника: кажда сторона треугольника меньше суммы
    двух других сторон.
*/

// System.Console.Write("Введите первое число : ");
// int oneNum = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число : ");
// int twoNum = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите третье число : ");
// int threeNum = Convert.ToInt32(Console.ReadLine());

// if((oneNum < twoNum + threeNum) && (twoNum < oneNum + threeNum) && 
// (threeNum < oneNum + twoNum))
// {
//     System.Console.WriteLine("Треугольник со сторонами такой длины может быть!");
// }
// else
// {
//     System.Console.WriteLine("Треугольник со сторонами такой длины не может быть!");
// }


/*  Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначи.
    Первые два числа Фибоначи: 0 и 1
    Если N = 5 -> 0 1 1 2 3
    Если N = 3 -> 0 1 1
    Если N = 7 -> 0 1 1 2 3 5 8

    Число Фибоначи - каждое последующее число является суммой двух предыдущих.
*/

// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// array[1] = 1;
// for(int i = 2; i < n; i++)
// {
//     array[i] = array[i - 2] + array[i - 1];
// }
// for(int j = 0; j < n; j++)
// {
//     System.Console.Write(array[j] + " ");
// }


/*  Задача 39. Напишите программу, которая перевернет одномерный массив
    (послений элемент будет на первом месте, а первый на последнем и т.д.)

    [1 2 3 4 5] -> [5 4 3 2 1]
    [6 7 3 6] -> [6 3 7 6]
*/

    // int m = new Random().Next(1, 10);
    // int[] array = new int[m];
    // System.Console.Write("Первый массив: ");
    // for(int i = 0; i < m; i++)
    // {
    //     array[i] = new Random().Next(0, 100);
    //     if(i == 0)
    //     {
    //         System.Console.Write("[");
    //     }
    //     System.Console.Write(array[i]);
    //     if (i != m-1)
    //     {
    //         System.Console.Write("; ");
    //     }
    //     else
    //     {
    //         System.Console.Write("]");
    //     }
    // }
    // System.Console.WriteLine("");
    // System.Console.Write("Второй массив: ");
    // int[] arrayTwo = new int[m];
    // for(int i = 0; i < m; i++)
    // {
    //     arrayTwo[i] = array[m-(i+1)];
    //     if(i == 0)
    //     {
    //         System.Console.Write("[");
    //     }
    //     System.Console.Write(arrayTwo[i]);
    //     if (i != m-1)
    //     {
    //         System.Console.Write("; ");
    //     }
    //     else
    //     {
    //         System.Console.Write("]");
    //     }
    // }

// Второй вариант решения

int m = new Random().Next(1, 10);
int[] array = new int[m];
void ArrayPrint()
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        if(i == 0)
        {
        System.Console.Write("[");
        }
        System.Console.Write(array[i]);
        if(i != array.Length-1)
        {
            System.Console.Write(";");
        }
        else
        {
            System.Console.Write("]");
        }
    }
}
void ArrayInversion()
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int tempOne = array[array.Length - (i+1)];
        int tempTwo = array[i];
        array[i] = tempOne;
        array[array.Length - (i + 1)] = tempTwo;
    }
}
void ArrayInversionPrint()
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0)
        {
            System.Console.Write("[");
        }
        System.Console.Write(array[i]);
        if(i != array.Length-1)
        {
            System.Console.Write(";");
        }
        else
        {
            System.Console.Write("]");
        }
    }
}

ArrayPrint();
ArrayInversion();
System.Console.WriteLine("");
ArrayInversionPrint();