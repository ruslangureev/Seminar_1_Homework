Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int c = int.Parse(Console.ReadLine());

if (a>b && a>c)
{
    Console.WriteLine("Max= " + a );
}
else if (b>a && b>c)
{
    Console.WriteLine("Max= " + b );
}
else
{
    Console.WriteLine("Max= " + c );
}
