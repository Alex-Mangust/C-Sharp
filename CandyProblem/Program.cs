// Задача с конфетами. Играет игрок и компьютер. Выигрывает тот, кто сделает последний ход.

System.Console.Write("Введите количество конфет: ");
int candy = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" ");
System.Console.WriteLine($"На столе лежат {candy} конфет");
System.Console.WriteLine("Играют два игрока (За второго играет компьютер). По очереди берут конфеты.");
System.Console.WriteLine("За один ход можно взять не больше 28 конфет.");
System.Console.WriteLine("Побеждает тот, кто делает последний ход.");
System.Console.WriteLine("Все конфеты аппонента достаются победителю.");
System.Console.WriteLine(" ");
System.Console.WriteLine(" ");
int candyGrabOne = 0, candyGrabTwo = 0, raund = 1;
int randomGo = new Random().Next(1, 3);
while(candy > 0)
{
    bool error = true;
    if (randomGo == 1)
    {
        while(error)
        {
            System.Console.WriteLine($"Раунд {raund}!");
            System.Console.WriteLine("Ваш ход. Сколько конфет вы хотите забрать?");
            candyGrabOne = Convert.ToInt32(Console.ReadLine());
            if(candyGrabOne > 0 && candyGrabOne < 29 && candyGrabOne < candy+1)
            {
                error = false;
                candy -= candyGrabOne;
                System.Console.WriteLine($"Вы забрали {candyGrabOne} конфет. Осталось {candy}.");
                randomGo = 2;
                raund++;
            }
            else if(candyGrabOne > 28)
            {
                System.Console.WriteLine("Ошибка! Вы можете взять не больше 28 конфет!");
            }
            else if(candyGrabOne < 1)
            {
                System.Console.WriteLine("Ошибка! Вы не можете взять меньше, чем 1 конфету!");
            }
            else
            {
                System.Console.WriteLine("Ошибка! Вы не можете взять больше конфет, чем осталось!");
                System.Console.WriteLine("Конфет осталось " + candy);
            }
            if(candy < 1)
            {
                System.Console.WriteLine("Поздравляю! Вы победили!");
            }
            System.Console.WriteLine(" ");
            System.Threading.Thread.Sleep(1000);
        }
    }
    else
    {
        System.Console.WriteLine($"Раунд {raund}!");
        System.Console.WriteLine("Ход противника.");
        if(candy > 28)
        {
            candyGrabTwo = new Random().Next(1, 29);
        }
        else
        {
            candyGrabTwo = candy;
        }
        candy -= candyGrabTwo;
        raund++;
        System.Console.WriteLine($"Ваш противник забрал {candyGrabTwo} конфет. Осталось {candy}.");
        randomGo = 1;
        if(candy < 1)
        {
            System.Console.WriteLine("Извините! Вы проиграли!");
        }
        System.Threading.Thread.Sleep(1000);
        System.Console.WriteLine(" ");
    }
}