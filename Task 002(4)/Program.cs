// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int len = NumberLen(number);
sum(number, len);






Console.Write(sum);