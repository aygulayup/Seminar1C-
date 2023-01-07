// Напишите программу, которая 
// 1. по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек 
// в этой четверти (х И у).

Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

string range = Range(num);

Console.WriteLine(range);

string Range(int number)
{
    if (number == 1) return "Диапазон координат (x > 0, y > 0)";
    if (number == 2) return "Диапазон координат (x < 0, y > 0)";
    if (number == 3) return "Диапазон координат (x < 0, y < 0)";
    if (number == 4) return "Диапазон координат (x > 0, y < 0)";
    return "неверная четверть";
}