// Задача 26
// Напишите программу, которая принимает нп вход 
// число и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int CountDigit(int num)
{
    int digit = 0;

    if (num == 0) return 1;
    while (num !=0)
    {
        digit++;
        // пока num не равно нулю мы каждую 
        // итерацию добавляем единицу к digits и отсекаем последнюю цифру num
        num /=10;
    }
    return digit;
}
Console.WriteLine($"{number} contains {CountDigit(number)} digit");