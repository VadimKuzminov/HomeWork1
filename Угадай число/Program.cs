Console.WriteLine("Игра \"Угадай число!\"");
Console.WriteLine("Как к Вам обращаться?:");
string nameUser;
nameUser = Console.ReadLine();
again://Для возврата к вводу числа, по другому не знаю как...
Random rand = new Random();
int userNumber;
Console.WriteLine($"{nameUser}, введите максимальное число которое будет использоваться для игры:");
userNumber = int.Parse(Console.ReadLine());
int iiNumber = rand.Next(0, userNumber);
int count = 0;


while (true)
{
    
    Console.Write("\nВведите число: ");
    count++;
    userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber < iiNumber)
    {
        Console.WriteLine("Введенное число меньше загаданного. Попробуйте ещё раз");
    }
    else if (userNumber > iiNumber)
    {
        Console.WriteLine("Введенное число больше загаданного. Попробуйте ещё раз");
    }
    else
    {
        Console.WriteLine($"Поздравляю {nameUser}, число угадано! Число попыток: {count}.");
        Console.ReadKey();
        Console.WriteLine("Хотите сыграть ещё раз? Нажмите 1(да)/0(нет)");
        int answer; 
        answer = int.Parse(Console.ReadLine());
        if (answer < 1)
        {
            Console.WriteLine("Спасибо за игру!");
            break;
        }
        userNumber = 0;
        count = 0;
        goto again;
    }

}

