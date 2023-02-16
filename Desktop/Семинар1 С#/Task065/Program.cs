// Задача 65: Задайте значения М и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от М до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M=4; N=8-> "4, 6,7,8"

Console.WriteLine("Введите целое число 1: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число 1: ");
int numberN = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(numberM, numberN);

void NaturalNumbers(int n, int m)
{
    if(n == m)
    {
        Console.Write($"{n} ");
        return;
    }
    
    if(n > m) 
        NaturalNumbers(n - 1, m);
    else
        NaturalNumbers(n + 1, m);
    
    Console.Write($"{n} ");

}