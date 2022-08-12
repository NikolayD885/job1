//Программа нахождения большего числа из двух
Console.WriteLine("Программа нахождения большего числа из двух");

Console.WriteLine("Введите первое число");

string? numberString = Console.ReadLine();

int numberA = int.Parse(numberString!);

Console.WriteLine("Введите второе число");

string? numberStringA = Console.ReadLine();

int numberB = int.Parse(numberStringA!);

if(numberA < numberB)
{
    Console.WriteLine("max=" + numberB);
    Console.WriteLine("min=" + numberA);
}

else
{
    Console.WriteLine("max=" + numberA);
    Console.WriteLine("min=" + numberB);
}