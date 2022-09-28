//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк (m):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
int[] array = new int[m];
Console.WriteLine("Ваш исходный массив: ");
FillArr(matrix);
PrintArr(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = matrix[i, j] + sum;
    }
    array[i] = sum;
    Console.WriteLine($"Сумма элементов строки №{i + 1} с индексом ({i}) = {sum}");
}

int min = array[0];
int index = 0;
for (int i = 0; i < n; i++)
{
    if (array[i] < min)
    {
        min = array[i];
        index = i;
    }
}
Console.WriteLine($"Наименьшая сумма элементов строки составляет {min} её индекс -> {index}");

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