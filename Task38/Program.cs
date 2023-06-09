// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size, int min, int max, int round = 2)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        // получаем cлучайное вещественное чмсло в нужном диапазоне
        //  с помощью "* (max - min) + min"
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }

    return arr;
}

void PrintArrayDouble(double[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

double MaxElem(double[] arr)
{
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinElem(double[] arr)
{
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;

}



double DifMaxMinElem(double max, double min)
{
    double dif = Math.Round(max - min, 2);
    return dif;
}


double[] array = CreateArrayRndDouble(5, 1, 10);
PrintArrayDouble(array);
Console.WriteLine($" => {MaxElem(array)} - {MinElem(array)} = {DifMaxMinElem(MaxElem(array), MinElem(array))}");
