// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(double[] arr) // Выводим одномерный массив
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
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

double[] FindColumnsAverage(int[,] matrix) // Находим среднее арифметическое каждого столбца
{
    int k = matrix.GetLength(1);
    double[] array = new double[k];
    double average = 0;
    k = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average = average + matrix[i, j];
        }
        average = Math.Round(average / matrix.GetLength(0), 1);
        array[k] = average;
        k++;
    }
    return array;
}

int[,] preDefinedMatrix = CreateMatrixRndInt(3, 4, 0, 10);
Console.WriteLine("Задан массив простых случайных чисел:");
PrintMatrix(preDefinedMatrix);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца заданного массива:");
PrintArray(FindColumnsAverage(preDefinedMatrix));