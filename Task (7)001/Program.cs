// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами от -10,0 до 10,0.

int m = new Random().Next(0, 10);
int n = new Random().Next(0, 10);
double[,] matrix = new double[n, m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
     for (int j = 0; j < matrix.GetLength(1); j++);
 }
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
         matrix[i,j] = (new Random().Next(-100,101)/10.0);
     }
     
 }
Console.Write(matrix);


// void PrintMatrix (double[,] matrix)
// {
// for (int i=0; i<matrix.GetLength(0); i++) 
// {
//     for (int j=0; j<matrix.GetLength(1); j++)
//     {
            
//       if(matrix[i,j]>=0 ) Console.Write("  "+matrix[i,j]);
//       else Console.Write(" "+matrix[i,j]);
//     }
//     Console.WriteLine();
// }
// }
// int row = new Random().Next(3,7);
// int column = new Random().Next(3,7);
// double[,] Matrix =new double[row,column];

// for (int i=0; i<Matrix.GetLength(0); i++) 
// {
//     for (int j=0; j<Matrix.GetLength(1); j++)
//     {
//       Matrix[i,j] = (new Random().Next(-100,101)/10.0);

//     }
// }
// PrintMatrix(Matrix);