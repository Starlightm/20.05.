// Задача 19 
// Напишите программу, которая принимает
//  на вход пятизначное число и проверяет, 
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigitNum = number / 10000;
Console.WriteLine($"first digit = {firstDigitNum}");
int secondDigitNum = (number / 1000) % 10;
Console.WriteLine($"second digit = {secondDigitNum}");
int fourthDigitNum = (number / 10) % 10;
Console.WriteLine($"fourht digit = {fourthDigitNum}");
int lastDigitNum = number % 10;
Console.WriteLine($"last digit = {lastDigitNum}");

void Palindrome(int num)
{
    if
    (number >= 10000 && number <= 99999)
    {
        if (firstDigitNum == lastDigitNum && secondDigitNum == fourthDigitNum)
        {
            Console.WriteLine($"{number} является палиндромом");
        }
        else
        {
            Console.WriteLine($"{number} не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Введeно не пятизначное число");
    }
}

Palindrome(number);
