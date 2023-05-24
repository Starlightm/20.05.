// Напишите программу, которая будет принимать на вход
// два числа и выводить, является ли первое число кратным второму.
// Если первое число не кратно второму, то программа  выводит остаток
// от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 ->  кратно


// int Remainder(int num1, int num2)
// {
//     int remainder = num1 % num2;
//     return remainder;
// }

// Console.WriteLine ("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int remainder = Remainder(number1, number2);
// if (remainder == 0)
// {
//    Console.WriteLine($"Число {number1} кратно числу {number2}");
// }
//    else
// {
//     Console.WriteLine($"Число {number1} не кратно числу {number2} остаток от деления - {remainder}");
// }

//    способ 2

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = Remain(num1, num2);
string printLine = result == 0 ? "кратно" : $"не кратно. остаток {result}";
Console.WriteLine(printLine);

int Remain(int number1, int number2)
{
    int res = number1 % number2;

    return res;
}