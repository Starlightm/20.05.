// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int EnterNumber(string prompt)
{
    Console.WriteLine(prompt);
    return Convert.ToInt32(Console.ReadLine());

}

int Ackerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (m == 0)
        return Ackerman(n - 1, 1);
    else
        return Ackerman(n - 1, Ackerman(n, m - 1));
}



int n = EnterNumber("Enter N");
int m = EnterNumber("Enter M");
Console.Write($"A({n},{m}) => {Ackerman(n, m)}");