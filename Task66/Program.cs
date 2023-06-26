// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных 
//  элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int GetSumNumbersInRange(int n, int m)
{
    if (m == n)
        return m;
    if (n < m)
        return n + GetSumNumbersInRange(m, n + 1);
    else
        return m + GetSumNumbersInRange(m + 1, n);
}   


Console.WriteLine("Введите два натуральных числа: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от {numberM} до {numberN} - {GetSumNumbersInRange(numberM, numberN)}");