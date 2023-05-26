// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ShowSecondDigit(int num)
{
    int secondDigit = (num / 10) % 10;
    return secondDigit;
}

Console.Write($"Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

 if (number >= 100 && number <= 999)
{
 Console.WriteLine($"Вторая цифра числа {number} -> {ShowSecondDigit(number)}");   
int secondDigit = ShowSecondDigit(number);
}


