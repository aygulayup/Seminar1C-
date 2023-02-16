// Задача 69: Напишите программу, которая на вход принимает 
// два числа А и В, и возводит число А в целую степень В с помощью рекурсии.
// A = 3: B = 5 -> 243 (35)
// A = 2: B = 3 - > 8

Console.WriteLine("Введите целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое натуральное число: ");
int numB = Convert.ToInt32(Console.ReadLine());

int pow = NumberPower(numA, Math.Abs(numB)); // Math.Abs(numB) - число по модулю
double powD = (double) 1 / pow; //десятичное число с плавающей запятой
Console.WriteLine(numB > 0 ? $"{pow}" : $"1/{pow} = {powD}");


int NumberPower(int number, int power)
{
    if(power == 0) return 1;// условие выхода из рекурсии, когда цифра дойдет до 0
    return NumberPower(number, power - 1) * number;
}