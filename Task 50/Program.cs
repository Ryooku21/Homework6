// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

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

void PrintMatrix(int[,] matrix) // Выводим массив
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

Console.WriteLine("Введите индекс строки элемента массива:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца элемента массива:");
int column = Convert.ToInt32(Console.ReadLine());

int [,] preDefinedMatrix = CreateMatrixRndInt(3,4,0,10);
Console.WriteLine("Задан массив простых чисел:");
PrintMatrix(preDefinedMatrix);
int element = 0;

if (row < 0 || row > preDefinedMatrix.GetLength(0)-1) 
{
    Console.WriteLine("Элемента с указанным индексом не существует");
}
else if (column < 0 || column > preDefinedMatrix.GetLength(1)-1)
{
    Console.WriteLine("Элемента с указанным индексом не существует");
}
else 
{
    element = preDefinedMatrix[row,column];
    Console.WriteLine($"Элемент с указанным индексом равен: {element}");
}