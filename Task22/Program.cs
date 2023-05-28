// Напишите программу, которая на вход принимает число (N) 
// и выдает таблицу квадратов чисел от 1 до N.
// 5 - > 1, 4, 9, 16, 25.
// 2 - > 1, 4.

Console.WriteLine("Введите натураольное число");
int num = Convert.ToInt32(Console.ReadLine());

SquareTable(num);

void SquareTable(int n)
{
    int count = 1;
    while (count <= n)
    {
        Console.WriteLine($"{count,3} -> {count * count,4}");
        count++;
    }
}