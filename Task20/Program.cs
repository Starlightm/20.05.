// double d = Math.Sqrt(5);
// double num = 5.099874453;
// double dRound = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRound);

// Напишите программу, которая принимает 
// на вход координаты двух точек
// // и находит расстояние между ними в 2D пространстве

// квадрат гипотенузы равен сумме квадратов катетов/
// гипотенуза - расстояние между а и b

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B ( 1, -1) -> 7,21

double DistanceFromCoordinates(int ax, int ay, int bx, int by)
{
    double sumCathetus = (bx - ax) * (bx - ax) + (by - ay) * (by - ay);
    // Далее вычисляем квадртный корень из суммы квадартов
    //  катетов/это и есть гипотенуза- искомое расстояние
    double d = Math.Sqrt(sumCathetus);
    return d;
}

Console.WriteLine("Введите координату x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());


double result = DistanceFromCoordinates(x1, y1, x2, y2);
//  и далее округление :
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero); 
Console.WriteLine(resultRound);

// 2 способ

// int EnterCoordinate(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double Distance(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt(Math.Pow(x2 - x1,2)+(Math.Pow(y2 - y1,2)));
// }

// int xOfA = EnterCoordinate("Enter x for A");
// int yOfA = EnterCoordinate("Enter y for A");
// int xOfB = EnterCoordinate("Enter x for B");
// int yOfB = EnterCoordinate("Enter y for B");

// double result = Distance(xOfA, yOfA, xOfB, yOfB);

// System.Console.WriteLine("Distance between dots: ");
// System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero)); 