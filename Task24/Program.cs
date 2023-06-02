// Задача 24.
// Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number <= 0)
Console.WriteLine("Введено некорректное число");

int sumnumbers = Sumnumbers(number);
Console.WriteLine($" Сумма чисел от 1 до {number} = {sumnumbers}");



int Sumnumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}