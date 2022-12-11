// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

// void PrintArray(int[] arr) // Вывод одномерного массива (использовалось для проверки)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         if (i == arr.Length - 2)
//         {
//             Console.Write($"{arr[i]}");
//         }
//         else
//         {
//             Console.Write($"{arr[i]}, ");
//         }
//     }
//     Console.Write("]");
// }

int[,,] CreateThreeDimAray(int rows, int columns, int depth, int min, int max) // Задаем массив случайных целых чисел
{
    int[,,] arrayThreeD = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < arrayThreeD.GetLength(0); i++)
    {
        for (int j = 0; j < arrayThreeD.GetLength(1); j++)
        {
            for (int k = 0; k < arrayThreeD.GetLength(2); k++)
            {
                arrayThreeD[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return arrayThreeD;
}

void PrintThreeDimensionalArray(int[,,] arrayThreeD) // Выводим трехмерный массив
{
    for (int i = 0; i < arrayThreeD.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arrayThreeD.GetLength(1); j++)
        {
            for (int k = 0; k < arrayThreeD.GetLength(2); k++)
            {
                Console.Write($" {arrayThreeD[i, j, k]}({i},{j},{k})", 3);
            }
        }
        Console.WriteLine(" |");
    }
}

int[] ConvertThreeDimensionsToOne(int[,,] arrayThreeD) // Переводим трехмерный массив в одномерный
{
    int[] array = new int[arrayThreeD.Length + 1];
    int h = 0;
    for (int i = 0; i < arrayThreeD.GetLength(0); i++)
    {
        for (int j = 0; j < arrayThreeD.GetLength(1); j++)
        {
            for (int k = 0; k < arrayThreeD.GetLength(2); k++)
            {
                array[h++] = arrayThreeD[i, j, k];
            }
        }
    }
    return array;
}

int[] SortArrayDescending(int[] array) // Упорядочиваем массив по убыванию
{
    int temp = array[0];
    for (int i = array.Length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            {
                if (array[j] < array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    return array;
}

int[] ChangeSimilarNumbers(int[] array) // Заменяем повторяющиеся числа в массиве
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            array[i + 1] = array[i + 1] - 1;
        }
    }
    return array;
}

bool CheckSimilarNumbers(int[] array) // Проверяем есть ли в массиве повторяющиеся числа
{
    bool similarNumbers = false;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            similarNumbers = true;
        }
    }
    return similarNumbers;
}

int[,,] ConvertOneDimArrayToThreeDim(int[,,] arrayThreeD, int[] array) // Возвращаем одномерный массив в трехмерный
{
    int h = 0;
    for (int i = 0; i < arrayThreeD.GetLength(0); i++)
    {
        for (int j = 0; j < arrayThreeD.GetLength(1); j++)
        {
            for (int k = 0; k < arrayThreeD.GetLength(2); k++)
            {
                arrayThreeD[i, j, k] = array[h++];
            }
        }
    }
    return arrayThreeD;
}

int[,,] threeDimensionalArray = CreateThreeDimAray(2, 2, 2, 20, 99); // Задаем трехмерный массив
int[] arrayOneD = new int[threeDimensionalArray.Length]; // Задаем одномерный массив с длиной по количеству элементов трехмерного
arrayOneD = ConvertThreeDimensionsToOne(threeDimensionalArray); //Переводим трехмерный массив в одномерный
arrayOneD = SortArrayDescending(arrayOneD); // Сортируем элементы одномерного массива по убыванию
while (CheckSimilarNumbers(arrayOneD) == true) // Пока в массиве находятся повторяющиеся элементы, меняем их на новые
{
    arrayOneD = ChangeSimilarNumbers(arrayOneD);
}
threeDimensionalArray = ConvertOneDimArrayToThreeDim(threeDimensionalArray, arrayOneD); //Возвращаем значения в трехмерный массив
Console.WriteLine("Задан трехмерный массив разменостью 2 на 2 на 2 из неповторяющихся двухзначных чисел:");
PrintThreeDimensionalArray(threeDimensionalArray);