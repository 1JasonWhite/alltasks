//Задача 6.
//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Сейчас нужно ввести 3 числа");
Console.WriteLine("Введите 1-е число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-е число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3-е число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0)
{
    Console.WriteLine($"{number1} Четное");
}
else
{
    Console.WriteLine($"{number1} Нечетное число!");
}
if (number2 % 2 == 0)
{
    Console.WriteLine($"{number2} Четное");
}
else
{
    Console.WriteLine($"{number2} Нечетное число!");
}
if (number3 % 2 == 0)
{
    Console.WriteLine($"{number3} Четное");
}
else
{
    Console.WriteLine($"{number3} Нечетное число!");
}