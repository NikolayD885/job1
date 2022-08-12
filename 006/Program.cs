// Программа которая определяет является ли число четным

Console.WriteLine("Программа которая определяет является ли число четным");

Console.WriteLine("Введите число");

string? numberString = Console.ReadLine();

int numberA = int.Parse(numberString!);

int numberB = numberA %2;

if(numberB == 0)
{
    Console.WriteLine( + numberA + " четное число");
}

else
{
    Console.WriteLine( + numberA + " не четное число");
}

