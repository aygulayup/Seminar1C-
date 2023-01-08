// Задача 22: Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

    Console.WriteLine("Введите натуральное число: ");
    int num = Convert.ToInt32(Console.ReadLine());

while (num < 1)
{
    Console.WriteLine("Введите корректное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}

    SquareNum(num);

void SquareNum(int number)
{
    int index = 1;
    while (index <= number) 
    {
        Console.WriteLine($"{index, 3} -> {index * index, 3}");
        index ++;
    }
}
