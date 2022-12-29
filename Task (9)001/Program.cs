//Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(n));

string PrintNumbers(int numbers) 
{
    if (numbers == 1) return "1";
    string answer = numbers + " " + PrintNumbers(numbers - 1);
    return answer; 
}