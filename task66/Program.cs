// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumDigitsNumbers(int numberM, int numberN)
{
    if (numberM == numberN)
        return numberN;
    else return numberM + SumDigitsNumbers(numberM + 1, numberN);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {SumDigitsNumbers(numberM, numberN)}");