// 16. Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());

// int square1 = number1 * number1;
// int square2 = number2 * number2;
// if (square1 == number2 || square2 == number1)
// {
//       Console.WriteLine($"{number1}, {number2} -> да");  
// }
// else
// {
//     Console.WriteLine($"{number1}, {number2} -> нет"); 
// }



Console.WriteLine(IsSquare(number1, number2) ? "да" : "нет");
bool IsSquare(int n1, int n2)
{
    return n1 / n2 == n2 || n2 /n1 == n1;
}