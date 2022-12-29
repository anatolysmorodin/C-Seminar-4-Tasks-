//Задайте два двумерных массива (от 0 до 10). 
//Напишите программу, которая будет находить произведение двух массивов (поэлементное).

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = new int[2,6];
FillMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = new int[2,6];
FillMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();

int[,] finalMatrix = new int[2,6];
    for (int i = 0; i < finalMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < finalMatrix.GetLength(1); j++)
        {
            finalMatrix[i,j] = matrix1[i,j]*matrix2[i,j];
        }
    
    }
    Console.WriteLine("Произведение двух массивов (поэлементное): ");
    PrintMatrix(finalMatrix);