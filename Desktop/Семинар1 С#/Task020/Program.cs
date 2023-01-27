// Задача 20: Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


int x1 = InsertPositon("Введите координату Х первой точки:"); 
int y1 = InsertPositon("Введите координату У первой точки:");
int x2 = InsertPositon("Введите координату X второй точки:"); 
int y2 = InsertPositon("Введите координату Y второй точки:");

double distance = Distance(x1, y1, x2, y2);
double disToZero = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine(disToZero);


int InsertPositon(string text)
{
    Console.Write(text);
    int pos = Convert.ToInt32(Console. ReadLine());
    return pos;
}

double Distance(int xa, int ya, int xb, int yb)
{
    int distance = (xb - xa) * (xb - xa) + (yb - ya) * (yb - ya);
    return Math.Sqrt(distance);
}

