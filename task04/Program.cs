﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Покажу максимальное из 3х чисел!");

Console.WriteLine("Введи 1-ое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи 2-ое число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи 3-е число");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number2 > max)
{
    max = number2;
}
if(number3 > max)
{
    max = number3;
}
Console.WriteLine("Максимальное число {0}" , max);




//Второй вариант решения задачи:

// Console.WriteLine("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int numberC = Convert.ToInt32(Console.ReadLine());

// if(numberA > numberB) Console.WriteLine($"Максимальное число: {numberA}");
// if(numberB > numberC) Console.WriteLine($"Максимальное число: {numberB}");
// if(numberC > numberA) Console.WriteLine($"Максимальное число: {numberC}");