//Задача 2.
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());


if (number1 > number2)
{
    Console.WriteLine("{0} наибольшее число", number1);
}
else
{
    Console.WriteLine("{0} наибольшее число", number2);
}
if(number1 < number2)
{
    Console.WriteLine("{0} наименьшее число", number1);
}
else
{
    Console.WriteLine("{0} наименьшее число", number2);
}

//add comment 

