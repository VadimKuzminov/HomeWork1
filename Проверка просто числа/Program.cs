bool prostoe = true;
Console.WriteLine("введите число:");
int n = int.Parse(Console.ReadLine());
int i = 2;
while (i <= n - 1)
{
    if (n % i == 0)
    {
        prostoe = false;
        Console.WriteLine("число составное");


        break;
    }
    else
    {
        prostoe = true;
        Console.WriteLine("число простое");
        break;
    }
    i++;
}
Console.ReadKey();
