// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void ArrayPrint (int[] a)
{
    Console.Write("[");
    for (int i = 0; i < a.Length - 1; i++) Console.Write($"{a[i]}, ");
    Console.WriteLine($"{a[a.Length-1]}]");
}
int[] Array = new int[10];
int sumnech = 0;
int[] numbers = new int[size];

for (int i = 0; i < Array.Length; i++) Array[i] = new Random().Next(0,9);
ArrayPrint(Array); 

for (int i = 0; i < Array.Length; i+=2)
sumnech = sumnech + numbers[i];

Console.Write ($"Сумма элементов на нечетных позиция:{sumnech}");