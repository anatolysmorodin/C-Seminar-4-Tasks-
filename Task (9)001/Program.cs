//Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(1, n));

string PrintNumbers(int start, int end) 
{
    if (start == end) return end.ToString();
    string answer = start + " " + PrintNumbers(start + 1, end);
    return answer; 
}