// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
string string_x = Convert.ToString(x);

int summ = 0;

for (int i = 0; i < string_x.Length; i++)
{
   string a = Convert.ToString(string_x[i]);
   summ = summ + Convert.ToInt32(a);
}
Console.WriteLine(summ);