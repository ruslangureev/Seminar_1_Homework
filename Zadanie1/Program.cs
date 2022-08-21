Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
if (a < b)
{
    Console.WriteLine("Max = " + " " + b + "," + " " + "Min=" + " " + a );
}

else if(a > b)
{
    Console.WriteLine("Max = " + " " + a + "," + " " + "Min=" + " " + b );
  
}
else
{
    Console.WriteLine("Значения равны");
}


