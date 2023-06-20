﻿// Задача *39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArrayRndInt(int size, int min, int max)
{
Random rnd = new Random();
int[] arr = new int[size];  
for (int i = 0; i < size; i++)
{
arr[i] = rnd.Next(min, max + 1);
}
return arr;
}

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

// [1 2 3 4 5]->[5 4 3 2 1]

void ReversArray (int[] arr)

{
    for (int i = 0; i < arr.Length / 2; i++)
    {
    //     int  temp = arr[i];
    //     arr[i] = arr[arr.Length - 1 - i];
    //     arr[arr.Length - 1 - i] = temp;

         Swap(arr, i, arr.Length - 1 - i);
    }
}
void Swap (int[] arr, int elemLeft, int elemRight)

{
    int temp = arr[elemLeft];
    arr[elemLeft] = arr[elemRight];
    arr[elemRight] = temp;
}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);

Console.WriteLine();
ReversArray(array);
PrintArray(array);

Console.WriteLine();
Array.Reverse(array);

