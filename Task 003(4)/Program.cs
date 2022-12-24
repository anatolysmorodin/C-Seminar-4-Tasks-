// Напишите программу, которая задаёт массив из 8 случайных чисел (-10, 10) и выводит их на экран.

int[]array = new int[8];
Console.Write("[");

for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    string elements = Convert.ToString(array[i]);
    int convert = Convert.ToInt32(elements);
    Console.Write(convert.ToString() + ", ");
}
Console.WriteLine("]");

