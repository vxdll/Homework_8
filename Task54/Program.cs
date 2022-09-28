//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Console.WriteLine("Введите количество строк (m):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
Console.WriteLine("Исходный массив:");
FillArr(matrix);
PrintArr(matrix);

Console.WriteLine("Отсортированный массив по возрастанию элементов:");
StreamLine(matrix);
PrintArr(matrix);

void StreamLine(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    int t = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = t;
                }
            }
        }
    }
}


void PrintArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}