// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array)


{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray3(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void ColumnsSum(int[,] array, double[] columnsSum)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            columnsSum[j] += array[i, j];
        }
    }
}
int[,] matrix = new int[3, 3];
void ColumnsAverage(int[,] array1, double[] array, double[] columnsAverage)
{
    for (int i = 0; i < array.Length; i++)
    {
        columnsAverage[i] = Math.Round(array[i] / matrix.GetLength(0), 1);
    }
}



double[] columnsSum = new double[matrix.GetLength(1)];
double[] columnsAverage = new double[matrix.GetLength(1)];
FillArray(matrix);
PrintArray(matrix);
ColumnsSum(matrix, columnsSum);
Console.WriteLine();
PrintArray3(columnsSum);
Console.WriteLine();
ColumnsAverage(matrix, columnsSum, columnsAverage);
PrintArray3(columnsAverage);