// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void ArrayPrint (int[] a)
{
    Console.Write("[");
    for (int i = 0; i < a.Length - 1; i++) Console.Write($"{a[i]}, ");
    Console.WriteLine($"{a[a.Length-1]}]");
    
}
int[] Array = new int[10];

for (int i=0; i < Array.Length; i++) Array[i] = new Random().Next(0,11);
ArrayPrint(Array);
int sum = 0;
for (int i = 0; i<Array.Length; i++) 
{
    if (i % 2 ==1)
    sum = sum + Array[i];
}
Console.WriteLine($"Сумма элементов на нечетных индексах: {sum}");



