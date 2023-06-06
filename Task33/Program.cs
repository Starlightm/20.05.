﻿// Задача* 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateFillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    int lenght = arr.Length;
    Console.Write("[");
    for (int i = 0; i < lenght; i++)
    {
        if (lenght - i > 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


bool ContainsNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Lenght; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

int[] array = CreateFillArray(10, -10, 10);
PrintArray(array);

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ContainsNumber(array, number) ? $"Массив содержит число {number}" : $"Массив не содержит число {number}");

