// Программа которая показывает все четные числа от 1 до N
Console.WriteLine("Программа вывода четных чисел от 1 до N");

Console.WriteLine("Введите число");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString!);

for (int i = 1; i <= number; i++)

if (i % 2 == 0)

{
  Console.Write(i + " "); 
}
