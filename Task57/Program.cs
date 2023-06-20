// Задача *57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.Семинар 8/ время 2/06

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}


//метод перевода двумерного массива в одномерный/принимает 
//на входе двумерный и выдает одномерный 
int[] MatrixToArray(int[,] matrix)
{
    //показывает общее колво элементов в массиве
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //присваиваем значения элементов двумерного массива - одномерному
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}
// печать одномерного массива
void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

//подсчитывает элементы и печатает 
void CountFrequencies(int[] array)
{
    int currentNumber = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNumber) count++;
        else
        {
            Console.WriteLine($"Число {currentNumber} встречается {count} раз");
            currentNumber = array[i];
            count = 1;
        }
    }
    // для вывода последнего значения
    Console.WriteLine($"Число {currentNumber} встречается {count} раз");
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
int[] array = MatrixToArray(array2d);
Array.Sort(array);

PrintMatrix(array2d);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
CountFrequencies(array);
