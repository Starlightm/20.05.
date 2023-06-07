// *Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100);
    }
}


void PrintArray(int[] arr)
{
    int lenght = arr.Length;
    Console.Write("[");
    for (int i = 0; i < lenght; i++)
    {
        if (lenght - i > 1)
            Console.Write($"{arr[i]},");
        else
            Console.Write($"{arr[i]}.");
    }
    Console.WriteLine("]");
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);