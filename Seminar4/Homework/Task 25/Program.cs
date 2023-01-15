// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int degree (int a, int b)
{
    int prod = 1;
    for (int i = 1; i <= b; i++)
    {
       prod = prod * a ;
    } 
    return prod;
}

int numberA = ReadNumber("Введите число A: ");
int numberB = ReadNumber("Введите число B: ");

int count1 = degree(numberA, numberB);
Console.WriteLine (count1);