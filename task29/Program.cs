// Задача 29
// Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = { 1, 2, 5, 7, 19, 6, 1, 33 };


void PrintArray(int[] arr)
{
    Console.Write("[");

    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

PrintArray(array);

// не знаю как сделать запятые после каждой цифры в массиве при выводе в консоль
// О скобках, подсмотрел в интернете :)