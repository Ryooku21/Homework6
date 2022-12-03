// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (i == arr.Length - 2)
        {
            Console.Write($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}, ");
        }
    }
    Console.Write("]");
}

string InputNumbers() // Пользователь вводит любое количество чисел до M 
{
    string input = "";
    string result = "";
    while (input != "M")
    {
        input = Console.ReadLine()!;
        if (input != "M")
        {
            result = result + input + " ";
        }
    }
    return result;
}

int FindNumbersAboveZero(int[] arr) // Из введенных чисел находит количество чисел больше 0
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("1. Вводите любые числа.");
Console.WriteLine("2. После ввода числа нажмите Enter.");
Console.WriteLine("3. Чтобы завершить процедуру ввода, введите M.");

string[] toArray = InputNumbers().Split();
int[] array = Array.ConvertAll(toArray, s => int.TryParse(s, out var x) ? x : 0); // Конвертирует строку в числовой массив, если в строке не число, ставит 0

Console.WriteLine("Список введенных чисел:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Из них введено чисел больше нуля: {FindNumbersAboveZero(array)}");