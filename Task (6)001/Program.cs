// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Bведите числа через пробел: ");
string inputText = Console.ReadLine();
string[] stringArray = inputText.Split(' ');
int[] Array = new int[stringArray.Length];
int count = 0;

for (int i = 0; i < stringArray.Length; i++)
{
    Array [i] = int.Parse(stringArray[i]);
}

for (int i = 0; i < Array.Length; i++)
{
    Console.Write(Array[i] + " ");
}

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > 0)  count +=1;
}
Console.WriteLine($"Введено чисел больше нуля: " + count);
