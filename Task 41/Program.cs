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

string InputNumbers()
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

int FindNumbersAboveZero(int[] arr)
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
int[] array = Array.ConvertAll(toArray, s => int.TryParse(s, out var x) ? x : 0);

Console.WriteLine("Список введенных чисел:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Пользователь ввел {FindNumbersAboveZero(array)} чисел больше нуля.");



