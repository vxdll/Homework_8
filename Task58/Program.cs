//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите количество строк (m) для двух матриц:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n) для двух матриц:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] resultMatrix = new int[m,n];

Console.WriteLine("Первая матрица: ");
int[,] firstMatrix = new int[m, n];
FillArr(firstMatrix);
PrintArr(firstMatrix);

Console.WriteLine("Вторая матрица: ");
int[,] secondMatrix = new int[m, n]; // вторая  матрица
FillArr(secondMatrix);
PrintArr(secondMatrix);

Console.WriteLine("Результат умножения первой матрицы на вторую:");
MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
PrintArr(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < m; i++)
    {
        int res = 0;
        for (int j = 0; j < n; j++)
        {
            res = firstMatrix[i, j] * secondMatrix[i, j];
            resultMatrix[i, j] = res;
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