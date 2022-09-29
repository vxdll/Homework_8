/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

int[,,] array = new int[2, 2, 2];
FillArr(array);
PrintArr(array);

void FillArr(int[,,] matrix)
{
    int[] newArr = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        newArr[i] = new Random().Next(10, 91);
        number = newArr[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (newArr[i] == newArr[j])
                {
                    newArr[i] = new Random().Next(10, 100);
                    j = 0;
                    number = newArr[i];
                }
                number = newArr[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = newArr[count];
                count++;
            }
        }
    }
}

void PrintArr(int[,,] matrix)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($" {array[i, j, z]} ({i},{j},{z})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

