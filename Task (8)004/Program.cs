// Cформируйте трёхмерный массив из двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int rows = new Random().Next(2,3);
int columns = new Random().Next(2,3);
int lenghts = new Random().Next(2,3);
int[,,]array3d = new int [rows, columns, lenghts];

Console.WriteLine ("Индексы элементов в трехмерном массиве: ");
for (int i = 0; i < array3d.GetLength(0); i++)
{
    for (int j = 0; j < array3d.GetLength(1); j++)
    {
        for (int k = 0; k < array3d.GetLength(2); k++)
        {
            array3d[i,j,k] = new Random().Next(10,100);
            Console.Write($"{array3d[i,j,k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}