// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>0 && number < 6)
{
    Console.WriteLine("Рабочий");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной");
}
