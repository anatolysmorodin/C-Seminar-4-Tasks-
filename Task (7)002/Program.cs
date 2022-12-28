// //Напишите программу, которая на вход принимает число, 
// //и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

int[,] FillMatrix (int[,] matrix)
 {
     for (int i=0; i<matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)  
         {
             matrix[i, j] = new Random().Next(0, 10);
         } 
           
     }
        return matrix;
 }

void PrintMatrix(int[,]matrix)
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

int [,] matrix = new int[6,8];
matrix = FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("\n Введите число: ");
int number = int.Parse(Console.ReadLine());
bool IsNumberInMatrix = false;

for (int i=0; i<matrix.GetLength(0); i++)
 {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
         if (matrix[i , j] == number)
         {
             IsNumberInMatrix = true;
             Console.Write("Число находится на месте с номером индекса: " + Convert.ToInt32(i) + ", " );
             Console.WriteLine(Convert.ToInt32(j));
         }
     }
 }

 if (IsNumberInMatrix)
 {
     Console.WriteLine ($"Число {number} есть в массиве");
 }
 else
 {
     Console.WriteLine($"Числа {number} нет в массиве");
 }
