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

// int[] FindIndex(int[,] matrix)
// {
//     int[] array = new int[2];
//     int min = matrix[0, 0];
//     int rowIndex = 0;
//     int columnIndex = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (min > matrix[i, j])
//             {
//                 min = matrix[i, j];
//                 rowIndex = i;
//                 columnIndex = j;
//             }
//         }

//     }
//     array[0] = rowIndex;
//     array[1] = columnIndex;
//     return array;
// }
// void PrintArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }

// }

// void PrintMatrix1(int[,] matrix, int[] array)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write(" ");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i != array[0] && j != array[1])
            
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
//             else Console.Write($"{matrix[i, j],4} ");
//         }
//         Console.WriteLine(" ");
//     }

// }

// int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
// PrintMatrix(array2D);
// Console.WriteLine();
// int[] arr= FindIndex(array2D);
// PrintMatrix1(array2D, arr);


// int[] ReverceMatrixToArray(int[,] matrix)
// {
//     int y = 0;
//     int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             arr[y] = matrix[i, j];
//             y++;
//         }
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

// int[,] array2D = CreateMatrixRndInt(2, 3, 0, 10);
// PrintMatrix(array2D);
// Console.WriteLine(" ");
// int[] array = ReverceMatrixToArray(array2D);
// PrintArray(array);
// Array.Sort(array);
// PrintArray(array);

// void PrintResult(int [] arr)
// {
// int count = 1;
// int num = arr[0];
// for (int i = 1; i < arr.Length; i++)
// {
//     if (array[i] == num) count ++;
//     else 
//     {
//         Console.WriteLine($"{num} = {count}");
//         num = arr[i];
//         count = 1;
//     }
// }
// Console.WriteLine($"{num} = {count}");
// }
// PrintResult(array);


// int[,] RemoveRowCol(int[,] matrix, int[] index)
// {
//     int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
//     int m = 0;
//     int n = 0;
//     for (int i = 0; i < newMatrix.GetLength(0); i++)
//     {
//         if (m == index[0]) m++;

//         for (int j = 0; j < newMatrix.GetLength(1); j++)
//         {

//             if (n == index[1]) n++;
//             newMatrix[i, j] = matrix[m, n];
//             n++;
//         }
//         n = 0;
//         m++;
//     }
//     return newMatrix;
// }


// int[] FindPositionMinElement(int[,] mass)
// {
//     int[] array = new int[2];
//     int min = mass[0, 0];
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             if (mass[i, j] < min)
//             {
//                 min = mass[i, j];
//                 array[0] = i;
//                 array[1] = j;
//             }
//         }
//     }
//     return array;
// }