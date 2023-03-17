// Задача 19

// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Digit = 9999;

//Следующим шагом будет проверяться, является ли введеное число пятизначным

if(Digit < number) Console.WriteLine();
else {
    Console.WriteLine("Введено неправильное число");
return;
}
int firstDigit = 1;
int fifthDigit = 1;

if (firstDigit > fifthDigit) Console.WriteLine("No");

else Console.WriteLine("Введено правильное число");











// if (firstDigit = fifthDigit)
// {
//     Console.WriteLine("да");
// }
// else Console.WriteLine("Нет");