﻿// Напишите программу, которая на вход принимает одно целое число N,
// а на выходе показывает все целые числа в промежутке от -N до N.
// например
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
 Console.WriteLine("Некорректный ввод.");
else
{
int i = -number;
while(i <= number)

{
    Console.Write($"{i} ");
    ++i;
}
}



