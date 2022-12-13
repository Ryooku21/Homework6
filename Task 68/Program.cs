// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число: ");
int numberM = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите натуральное число: ");
int numberN = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int Accerman(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    else
    {
        if ((number1 != 0) && (number2 == 0))
        {
            return Accerman(number1 - 1, 1);
        }
        else
        {
            return Accerman(number1 - 1, Accerman(number1, number2 - 1));
        }
    }
}

int accermanFunction = 0;
accermanFunction = Accerman(numberM, numberN);
Console.WriteLine($"Заданы два неотрицательных числа {numberM} и {numberN}.");
Console.WriteLine($"Результат вычисленияя функции Аккермана A(m,n) для заданных чисел равен: {accermanFunction}");