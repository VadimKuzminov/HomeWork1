
Console.WriteLine("Добрый день!Сколько чисел Вы хотите ввести?:");
int Size;
Size = int.Parse(Console.ReadLine());
int n = int.MaxValue;
int min = 0;
for (int i = 0; i < Size; i++)
{
    Console.WriteLine($"Введите [{i}] число");
    min = int.Parse(Console.ReadLine());

if ( n > min  )
        n = min;
}
Console.WriteLine($"минимальное число {n}");
