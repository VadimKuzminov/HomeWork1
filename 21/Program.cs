Console.WriteLine("Добро пожаловать в игру BlackJack!");
Console.WriteLine("Как к вам обращаться?:");
string name = Console.ReadLine();
Console.WriteLine($"{name} Сколько у Вас карт на руках?");
var Cards = int.Parse(Console.ReadLine());
var Result = 0;


for (int i = 0; i < Cards; i++)
{
    Console.WriteLine($"{name} введите пожалуйста номинал Вашей карты:");
    var Nominal = Console.ReadLine().ToLower();


    switch (Nominal)
    {
        case "2":
            Result += 2;
            break;
        case "3":
            Result += 3;
            break;
        case "4":
            Result += 4;
            break;
        case "5":
            Result += 5;
            break;
        case "6":
            Result += 6;
            break;
        case "7":
            Result += 7;
            break;
        case "8":
            Result += 8;
            break;
        case "9":
            Result += 9;
            break;
        case "10":
            Result += 10;
            break;
        case "j":
            Result += 11;
            break;
        case "q":
            Result += 11;
            break;
        case "k":
            Result += 11;
            break;
        case "t":
            Result += 11;
            break;
        default:
            Console.WriteLine("Такой карты нет в колоде.");
            break;
    }
}
Console.WriteLine($"сумма ваших карт {Result}");



Console.ReadKey();