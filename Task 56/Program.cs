// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // Задаем массив случайных целых чисел
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // Выводим двухмерный массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2}, ");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}

int FindLesserRow(int[,] matrix) //Находим первую строку с наименьшим количеством элементов
{
    int summ = 0;
    int lesserRow = 0;
    int row = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ = summ + matrix[i, j];

        }
        if (lesserRow == 0)
        {
            lesserRow = summ;
        }
        else
        {
            if (lesserRow > summ)
            {
                lesserRow = summ;
                row = i;
            }
        }
        summ = 0;
    }
    return row;
}


int[,] defaultMatrix = CreateMatrixRndInt(3, 4, 0, 10);
Console.WriteLine("Задан двухмерный массив разменостью 3 на 4:");
PrintMatrix(defaultMatrix);
Console.WriteLine();
int minRow = FindLesserRow(defaultMatrix);
Console.WriteLine($"Индекс строки с наименьшей суммой элементов {minRow}");
Console.WriteLine($"Номер строки с наименьшей суммой элементов {minRow + 1}");