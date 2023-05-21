// Напишите программу, которая на вход принимает 2 числа и проверяет
// является ли первое квадратом второго

// например:

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine($"Да, {num1} является квадратом числа {num2}");
}
else Console.WriteLine($"Нет, {num1} не является квадратом числа {num2}");
