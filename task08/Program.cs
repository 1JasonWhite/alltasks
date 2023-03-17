// Задача 8.
//Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
        int res = 2;
       
        while(res<=num)
        {
            Console.Write("{0} " , res);
            res = res +2;
        }
