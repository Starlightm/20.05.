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

int EnterCoordinate(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1,2)+(Math.Pow(y2 - y1,2)));
}

int xOfA = EnterCoordinate("Enter x for A");
int yOfA = EnterCoordinate("Enter y for A");
int xOfB = EnterCoordinate("Enter x for B");
int yOfB = EnterCoordinate("Enter y for B");

double result = Distance(xOfA, yOfA, xOfB, yOfB);

System.Console.WriteLine("Distance between dots: ");
System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero)); 