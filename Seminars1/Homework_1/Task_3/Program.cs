// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
    Console.Write("Четное");
}
else
{
    Console.Write("Нечетное");
}