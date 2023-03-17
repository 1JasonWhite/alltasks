// Задача 13.
//Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
int number = new Random().Next(10, 999); //установил автоматичский ввод
Console.WriteLine(number);

if (number < 99)
{
    Console.WriteLine("Нет третьей цифры !!!");
    return;
}

int secondDigit = number % 10; // остаток от деления
Console.WriteLine($"Третья цифра: {secondDigit}");
