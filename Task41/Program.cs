// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


// с помощью массива и методов
// пользователь вводит количество чисел 5 (m)
// создаем массив (m) и заполняем пользовательским вводом.
// 
// Convert.ToInt32(Console.ReadLine);


// 2 метод принимает на вход заполненный массив и выдает кол -во 
// чисел больше 0 в массиве и выводим результат


int GetNumber()
{
    Console.Write("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumber();
    }
        return array;
}

void PrintArray(int[] arr)

{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
}


int CountAboveZero(int[] arr)
{
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) count += 1;
}
    return count;
}

int number = GetNumber();
if (number < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

int[] array = CreateArray(number);
PrintArray(array);
int countAboveZero = CountAboveZero(array);
Console.WriteLine($"  Пользователь ввел {countAboveZero} цифр больше нуля");