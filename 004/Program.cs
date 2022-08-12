//Программа вывода максимального из трех чисел

Console.WriteLine("Программа вывода максимального из трех чисел");

Console.WriteLine("Введите первое число");

string? numberString = Console.ReadLine();

int numberA = int.Parse(numberString!);

Console.WriteLine("Введите второе число");

string? numberStringA = Console.ReadLine();

int numberB = int.Parse(numberStringA!);

Console.WriteLine("Введите третее число");

string? numberStringB = Console.ReadLine();

int numberC = int.Parse(numberStringB!);

int max = numberA;

if(numberB > numberA)
{
    max = numberB;
}
if(numberC > max)
{
    max = numberC;
}

Console.WriteLine("max = " + max);

