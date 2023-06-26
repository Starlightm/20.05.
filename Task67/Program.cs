// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int num)
{
    if (num == 0) return 0;

//                      сначала сохраняет в стеке числа 453 45 4 и затем складываем
//                         остаток от деления этих цифр (4 45 453) на 10
    return num % 10 + SumDigits(num / 10);
}

 
int number = EnterNumber("Enter number");
Console.WriteLine("Сумма цифр числа:");
Console.WriteLine(SumDigits(number));