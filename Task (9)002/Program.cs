//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное число N большее по значению чем M: ");
int n = int.Parse(Console.ReadLine());

int SumNumbers(int start, int end) 
{
    if (start == end) return end;
    return start + SumNumbers(start + 1, end);
}
Console.WriteLine ("Сумма натуральных элементов от M до N: " + SumNumbers(m,n));