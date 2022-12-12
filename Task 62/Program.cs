// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] CreateSpiralMatrix(int[,] matrix) // Задаем массив со спиральным наполнением
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    int iCounter = 0;
    int jCounter = 0;
    int filler = 1;

    while (iCounter < row && jCounter < column)
    {
        int i = iCounter;
        int j = jCounter;
        for (j = jCounter; j < column; j++)
        {
            matrix[i, j] = filler;
            filler++;
        }
        j = column - 1;

        for (i = iCounter + 1; i < row; i++)
        {
            matrix[i, j] = filler;
            filler++;
        }
        i = row - 1;
        for (j = column - 2; j >= jCounter; j--)
        {
            matrix[i, j] = filler;
            filler++;
        }
        j = jCounter;
        for (i = row - 2; i > iCounter; i--)
        {
            matrix[i, j] = filler;
            filler++;
        }
        iCounter++;
        jCounter++;
        row--;
        column--;

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
            if (j < matrix.GetLength(1) - 1 && matrix[i, j] < 10) Console.Write($" {0}{matrix[i, j]} ");
            else if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j]} ");
            else if (matrix[i, j] < 10) Console.Write($" {0}{matrix[i, j]} ");
            else Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine("|");
    }
}

int[,] spiralMatrix = new int[4, 4];
spiralMatrix = CreateSpiralMatrix(spiralMatrix);
Console.WriteLine("Задана матрица 4 на 4, заполненная по спирали:");
PrintMatrix(spiralMatrix);