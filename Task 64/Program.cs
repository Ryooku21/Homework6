// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число: ");
int numberN = Math.Abs(Convert.ToInt32(Console.ReadLine()));

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write ($"{num} ");
    NaturalNumbers (num - 1);
}

if (numberN == 0)
{
    Console.WriteLine("Введено некорректноре число, введите натуральное число больше 1!");
}
else
{
    Console.WriteLine($"Выведены все натуральные числа от {numberN} до 1:");
NaturalNumbers(numberN);
}