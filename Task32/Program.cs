// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


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
        if (i < lenght - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
void ChangesSign(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        // присваиваем каждому элементу цикла этот же элемент умноженный на минус 1
        arr[i] *= -1;
    }
}



int[] array = CreateFillArray(10, -10, 10);
PrintArray(array);

ChangesSign(array);
PrintArray(array);
