// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits(numb);
Console.WriteLine(sum);


int SumDigits(int number)
{
    if(number == 0) return 0;// условие выхода из рекурсии, когда цифра дойдет до 0
    return SumDigits(number / 10) + number % 10;
}