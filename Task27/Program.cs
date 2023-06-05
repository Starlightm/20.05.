// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int sumDigit = 0;
    // int remains;
    while (num != 0)
    {
        sumDigit += (num % 10);
        num /= 10;
    }
    // {
    //     remains = num % 10;
    //     sumDigit = sumDigit + remains;
    //     num = num / 10;
    // }
    return (sumDigit);
}
Console.WriteLine($"Сумма цифр {number} -> {SumDigit(number)}");