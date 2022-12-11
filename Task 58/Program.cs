// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // Задаем двухмерный массив случайных целых чисел
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

int[,] MatrixMultiplication(int[,] matrixOne, int[,] matrixTwo) // Перемножаем два двухмерных массива
{
    int[,] matrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            for (int h = 0; h < matrixOne.GetLength(1); h++)
            {
                matrix[i, j] += matrixOne[i, h] * matrixTwo[h, j];
            }
        }
    }
    return matrix;
}

int[,] matrixB = CreateMatrixRndInt(2, 2, 1, 10);
int[,] matrixA = CreateMatrixRndInt(2, 2, 1, 10);
int[,] matrixMultiplyResult = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

if (matrixA.GetLength(0) != matrixB.GetLength(1) || matrixA.GetLength(1) != matrixB.GetLength(0))
{
    Console.WriteLine
    ("Умножение невозможно, количество строк матриц должно совпадать с количеством столбцов");
}
else
{
    Console.WriteLine("Задан первый двухмерный массив:");
    PrintMatrix(matrixA);
    Console.WriteLine("Задан второй двухмерный массив:");
    PrintMatrix(matrixB);
    Console.WriteLine("Результат умножения двух заданных массивов:");
    matrixMultiplyResult = MatrixMultiplication(matrixA, matrixB);
    PrintMatrix(matrixMultiplyResult);
}