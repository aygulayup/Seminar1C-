// Задача 40: Напишите программу, 
// 1. которая принимает на вход три числа и 
// 2. проверяет, может ли существовать треугольник со сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool CheckTeorema(int num1, int num2, int num3)
{
    if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1) return true;
    else return false;
}

int number1 = InsertDigit("Введите число 1: ");
int number2 = InsertDigit("Введите число 2: ");
int number3 = InsertDigit("Введите число 3: ");
Console.WriteLine(CheckTeorema(number1, number2, number3) ? "да" : "нет");
