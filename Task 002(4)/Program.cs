// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int len = NumberLen(number);
SumNumbers(number, len);
int NumberLen(int a)
{
    int index = 0;
    while (a>0) 
    {
        a /=10;
        index++;
    }
return index;
}
Console.WriteLine(sum);






Console.Write(sum);