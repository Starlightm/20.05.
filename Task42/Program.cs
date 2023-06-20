﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 0) return number;
    else return -1;
}

int ConvertToBin(int num)
{
    int binNum = 0;
    int mult = 1;
    while (num > 0)
    {
        // 1 / 2 == 1
        binNum = binNum + (num % 2 * mult); //1110
        mult = mult * 10;
        num = num / 2;

    }
    return binNum;
}

int number = GetNumber();

if (number == -1)
{
    Console.WriteLine(" Число доджно быть неотрицательным");
    return;
}

Console.WriteLine($"Число {number} в двоичном представлении -> {ConvertToBin(number)}");