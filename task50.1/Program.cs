// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

//!!!Версия для поиска индекса!!!

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
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

Console.WriteLine("Enter the number of row");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of column");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
{
    Console.WriteLine("There's no such a number");
}
else
{
    Console.WriteLine($"The number with this index is {matrix[(a - 1), (b - 1)]}");
}