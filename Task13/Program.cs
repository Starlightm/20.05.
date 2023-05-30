// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// привести к трехзначному числу,остаток от деления на 10
// используем цикл. отрезаем на 10



int GetThreedDigitNumber(int number)
{
    if (number / 100 > 0)
    {
        int thirdDigitNumber = number;
        while (thirdDigitNumber >= 1000)
        {
            thirdDigitNumber = thirdDigitNumber / 10;
        }
        return thirdDigitNumber;
    }

else return 0;
}

int ThirdDigit(int number1)
{
    number1 = number1 % 10;
    return number1;
}

Console.WriteLine("Введите число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int thirdDigitNumber = GetThreedDigitNumber(number);
if (thirdDigitNumber > 0)
{
    int thirdDigitNumber1 = ThirdDigit(thirdDigitNumber);
    Console.WriteLine($"Третья цифра числа {number} - {thirdDigitNumber1}");
}
 else Console.WriteLine($"Третьей цифры нет");
