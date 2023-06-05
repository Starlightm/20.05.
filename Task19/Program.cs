// Задача 19 
// Напишите программу, которая принимает
//  на вход пятизначное число и проверяет, 
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

 
int firstDigitNum = number / 10000;
int secondDigitNum = number / 1000;
int fourthDigitNum = (number / 100) % 10;
int lastDigitNum = number % 10;

void Palindrome(int number);
if  (number < 10000 && number > 99999) 
{
    if (firstDigitNum == lastDigitNum && secondDigitNum == fourthDigitNum)
    {
        Console.WriteLine ($"{number} является палиндромом");
    }
     else 
    {
        Console.WriteLine ($"{number} не является палиндромом");
    }
}
    else 
    { 
        Console.WriteLine("Введeно не пятизначное число");
    }

int num = int.Parse(Console.ReadLine()!);

int Palindrome(number) = number;
 