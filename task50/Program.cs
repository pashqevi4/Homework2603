// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

//!!!Версия для поиска значения!!!

Console.WriteLine("Enter the number you're looking for");
int a = Convert.ToInt32(Console.ReadLine());
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

bool FindTheNumber(int[,] array)
{
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == a)
            {
                Console.WriteLine($"The number you are looking for is at {i + 1} row and {j + 1} column");
                flag = true;
                break;
            }
        }
        if (flag == true)
            break;
    }
    return flag;
}
int[,] matrix = new int[10, 10];
FillArray(matrix);
PrintArray(matrix);

if (FindTheNumber(matrix) == false)
{
    Console.WriteLine("There's no such a number");
}

