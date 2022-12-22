/// Напишите цикл, который принимает на вход 
/// два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число B: ");
int b = int.Parse(Console.ReadLine()!);
int NS = a;
int i = 1;

while (i<b)
{
    NS = NS*a;
    i++;
}
Console.WriteLine("Число А в степени B равно: " + NS);




