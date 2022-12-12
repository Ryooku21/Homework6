// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число: ");
int numberM = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите натуральное число: ");
int numberN = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int SummOfNumbersInBetweenStraight(int num1, int num2)
{
    int summ = 0;
    if (num1 == num2) return num2;
    summ = num1 + SummOfNumbersInBetweenStraight(num1 + 1, num2);
    return summ;
}

int SummOfNumbersInBetweenReverse(int num1, int num2)
{
    int summ = 0;
    if (num1 == num2) return num2;
    summ = num1 + SummOfNumbersInBetweenReverse(num1 - 1, num2);
    return summ;
}

int summOfBetweenElements = 0;
if (numberM < numberN)
{
    summOfBetweenElements = SummOfNumbersInBetweenStraight(numberM, numberN);
}
else
{
    if (numberM > numberN)
    {
        summOfBetweenElements = SummOfNumbersInBetweenReverse(numberM, numberN);
    }
    else
    {
        summOfBetweenElements = 0;
    }
}
Console.Write($"Сумма чисел в промежутке от {numberM} до {numberN} равна: {summOfBetweenElements}");