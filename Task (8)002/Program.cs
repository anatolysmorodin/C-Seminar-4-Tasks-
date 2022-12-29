//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rowSumNumber(int[,] array, int i)
{
    int RowSum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        RowSum += array[i, j];
    }
    return RowSum;
}

int[,] array = new int[6, 4];
FillArray(array);
PrintArray(array);

int minRowSum = 0;
int RowSum = rowSumNumber(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempRowSum = rowSumNumber(array, i);
    if (RowSum > tempRowSum)
    {
        RowSum = tempRowSum;
        minRowSum = i;
    }
}
Console.WriteLine();
Console.WriteLine($"({minRowSum + 1}) - Наименьшая сумма элементов в строке ({RowSum}).");