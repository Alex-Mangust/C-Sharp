// Напишите программу, которая выводит случайное число из отрезка 
// (10, 99) и показывает набольшую цифру числа.

// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

int num = new Random().Next(10, 100);

Console.WriteLine(num);
int num1 = num / 10;
int num2 = num % 10;
if(num1 > num2) Console.WriteLine("Число " + num1 + " больше чем " + num2); //канкатинация
else Console.WriteLine($"Число {num2} больше чем {num1}"); //Интерполяция 