﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine()); 

int[] array = new int[N];
System.Console.WriteLine(array[0]);
array[1] = 1;
for (int i = 2; i < array.Length; i++)
{
    array[i] = (array[i - 1]) + (array[i - 2]);
}

Console.WriteLine('[' + string.Join(", ", array) + ']');
