// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void ArrayPrint (int[] a)
{
    Console.Write("[");
    for (int i = 0; i < a.Length - 1; i++) Console.Write($"{a[i]}, ");
    Console.WriteLine($"{a[a.Length-1]}]");
}
int[] Array = new int[15];
int count = 0;

for (int i=0; i < Array.Length; i++) Array[i] = new Random().Next(100,1000);
ArrayPrint(Array);

for (int i=0; i<Array.Length; i++)
{
    if (i % 2==1) 
    count +=1;
   
}
Console.WriteLine("Четных элементов :" + count);