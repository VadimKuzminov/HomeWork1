using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Введите число: ");
double number = double.Parse(Console.ReadLine());



///проверка чётное число или нет при помощи деления с остатком.
if (number % 2 == 0)
{
    Console.WriteLine("Число чётное!");
}
else
{
    Console.WriteLine("Число не чётное!");
}
Console.WriteLine("Программа завершила свою работу.");
Console.ReadKey();
