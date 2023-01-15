// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumber (int a)
{
    int count = 0;
    while (Math.Abs(a) != 0)
    {
        count = count + Math.Abs(a%10);
        a = a/10;
    } 
    return count;
}

int number = ReadNumber("Введите число: ");

int sum = SumOfNumber(number);
Console.WriteLine (sum);