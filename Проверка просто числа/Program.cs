bool sostavnoe = true;
Console.WriteLine("введите число:");
int n = int.Parse(Console.ReadLine());
int k = 1;
while (k != n - 1)
{
    k++;
    if (n % k == 0)
    {
        sostavnoe = true;
        Console.WriteLine("число составное");
        break;
    }

    sostavnoe = false;
}
Console.WriteLine(sostavnoe);
Console.WriteLine("Число простое");